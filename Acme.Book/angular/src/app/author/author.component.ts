import { ListService, PagedResultDto } from '@abp/ng.core';
import { Confirmation, ConfirmationService } from '@abp/ng.theme.shared';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthorDto } from '@proxy/dtos/author-dtos';
import { AuthorService } from '@proxy/servises';
import { LocalizationService } from '@abp/ng.core';


@Component({
  selector: 'app-author',
  standalone: false,
  templateUrl: './author.component.html',
  styleUrl: './author.component.scss',
  providers: [ListService],
})
export class AuthorComponent implements OnInit {
  author = { items: [], totalCount: 0 } as PagedResultDto<AuthorDto>;

  isModalOpen = false;

  form: FormGroup;

  selectedAuthor = {} as AuthorDto;

  constructor(
    public readonly list: ListService,
    private authorService: AuthorService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService,
    private localization: LocalizationService ,
 
  ) {}

  ngOnInit(): void {
    this.buildForm();
    const authorStreamCreator = (query) => this.authorService.getList(query);
    this.list.hookToQuery(authorStreamCreator).subscribe((response) => {
      this.author = response;
    });
  }

  createAuthor() {
    this.selectedAuthor = {} as AuthorDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editAuthor(id: string) {
    this.authorService.get(id).subscribe((author) => {
      this.selectedAuthor = author;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedAuthor?.name || '', Validators.required],
      birthDate: [
        this.selectedAuthor?.birthDate
          ? this.parseDate(this.selectedAuthor.birthDate)
          : null,
        Validators.required,
      ],
      shortBio: [this.selectedAuthor?.shortBio || '', Validators.required],
    });
  }

  private parseDate(dateString: string): any {
    if (!dateString) return null;
    const date = new Date(dateString);
    return {
      year: date.getFullYear(),
      month: date.getMonth() + 1,
      day: date.getDate(),
    };
  }

  private formatDate(date: any): string {
    if (!date) return null;
    if (date instanceof Date) return date.toISOString();
    return new Date(date.year, date.month - 1, date.day).toISOString();
  }

  save() {
    if (this.form.invalid) {
      return;
    }
    const rawValues = this.form.value;
    rawValues.birthDate = this.formatDate(rawValues.birthDate);

    if (this.selectedAuthor.id) {
      this.authorService.update(this.selectedAuthor.id, rawValues).subscribe(() => {
        this.isModalOpen = false;
        this.form.reset();
        this.list.get();
      });
    } else {
      this.authorService.create(rawValues).subscribe(() => {
        this.isModalOpen = false;
        this.form.reset();
        this.list.get();
      });
    }
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure')
      .subscribe((status) => {
        if (status === Confirmation.Status.confirm) {
          this.authorService.delete(id).subscribe(() => this.list.get());
        }
      });
  }

toggleActiveStatus(author: AuthorDto) {
  this.authorService.setActiveStatus(author.id, !author.isActive)
    .subscribe(() => {
      author.isActive = !author.isActive;
      console.log('تم تحديث حالة المؤلف بنجاح');
    });
}
}
