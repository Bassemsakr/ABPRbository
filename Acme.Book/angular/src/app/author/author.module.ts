import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbDatepickerModule, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AuthorRoutingModule } from './author-routing.module';
import { AuthorComponent } from './author.component';
import { LocalizationModule } from '@abp/ng.core';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AuthorComponent
  ],
  imports: [
    CommonModule,
    AuthorRoutingModule,
    NgbDatepickerModule, 
    LocalizationModule,
    NgxDatatableModule,
    ReactiveFormsModule,
    NgbModule
  ]
})
export class AuthorModule { }
