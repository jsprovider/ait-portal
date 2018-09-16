import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { MyComponentComponent } from './invoice/my-component/my-component.component';
import { TestCompComponent } from './testComp/testComp.component';
import { CompanyComponent } from './company/company.component';
import {HttpClientModule} from '@angular/common/http';


@NgModule({
   declarations: [
      AppComponent,
      MyComponentComponent,
      TestCompComponent,
      CompanyComponent,
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
