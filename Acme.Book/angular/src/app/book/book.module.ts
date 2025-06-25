import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BookRoutingModule } from './book-routing.module';
import { BookComponent } from './book.component';
import { LocalizationModule } from '@abp/ng.core';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { NgbDatepickerModule, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    BookComponent
  ],
  imports: [
    CommonModule,
    BookRoutingModule,
     LocalizationModule,
     NgxDatatableModule,
     NgbDatepickerModule,
     FormsModule,
     ReactiveFormsModule,
     NgbModule
     
  ]
})
export class BookModule { }
