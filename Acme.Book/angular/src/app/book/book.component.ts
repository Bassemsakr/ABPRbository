import { ListService, PagedResultDto } from '@abp/ng.core';
import { Confirmation, ConfirmationService } from '@abp/ng.theme.shared';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BookDtos } from '@proxy/dtos';
import { BookDto } from '@proxy/dtos/book-dtos';
import { bookTypeOptions } from '@proxy/enums';
import { BookService } from '@proxy/servises';

@Component({
  selector: 'app-book',
  standalone: false,
  templateUrl: './book.component.html',
  styleUrl: './book.component.scss',
  providers: [ListService],
})
export class BookComponent implements OnInit {
  book = { items: [], totalCount: 0 } as PagedResultDto<BookDto>;
 isModalOpen = false; 
   form: FormGroup;
   bookTypes = bookTypeOptions;
    selectedBook = {} as BookDto;
  constructor(public readonly list: ListService, private bookService: BookService , private fb: FormBuilder,private confirmation: ConfirmationService ) {}

  ngOnInit() {
      this.buildForm(); 
    const bookStreamCreator = (query) => this.bookService.getList(query);

    this.list.hookToQuery(bookStreamCreator).subscribe((response) => {
      this.book = response;
    });
  }


createBook() {
  this.selectedBook = {} as BookDto;
  this.buildForm(); 
  this.isModalOpen = true;
}

buildForm(book?: BookDto) {
  this.form = this.fb.group({
    name: [book?.name || '', Validators.required],
    type: [book?.type || null, Validators.required],
    publishDate: [book?.publishDate ? this.parseDate(book.publishDate) : null, Validators.required],
    price: [book?.price || null, [Validators.required, Validators.min(0)]]
  });
}

private parseDate(dateString: string): any {
  if (!dateString) return null;
  const date = new Date(dateString);
  return {
    year: date.getFullYear(),
    month: date.getMonth() + 1,
    day: date.getDate()
  };
}

save() {
  if (!this.form || this.form.invalid) {
    return;
  }

  const formValue = {
    ...this.form.value,
    publishDate: this.form.value.publishDate ? 
      new Date(this.form.value.publishDate.year, 
               this.form.value.publishDate.month - 1, 
               this.form.value.publishDate.day).toISOString() : 
      null
  };

 const request = this.selectedBook.id
      ? this.bookService.update(this.selectedBook.id,formValue)
      : this.bookService.create(formValue);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  
  
}
editBook(id: string) {
  this.bookService.get(id).subscribe((book) => {
    this.selectedBook = book;
    this.buildForm(book); 
    this.isModalOpen = true;
  });
}
delete(id: string) {
  this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
    if (status === Confirmation.Status.confirm) {
      this.bookService.delete(id).subscribe(() => this.list.get());
    }
  });
}}
