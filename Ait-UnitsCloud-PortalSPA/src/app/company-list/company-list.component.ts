import { Component, OnInit, ViewChild } from '@angular/core';
import {CompanySummary} from '../dto/company-summary';
import { HttpClient } from '@angular/common/http';
import { Variable } from '@angular/compiler/src/render3/r3_ast';
import {MatSort, MatTableDataSource, MatPaginator} from '@angular/material';
import {ComapnyListDto} from './Comapny-list-Dto';

@Component({
  selector: 'app-company-list',
  templateUrl: './company-list.component.html',
  styleUrls: ['./company-list.component.css']
})
export class CompanyListComponent implements OnInit {
  companyList: any;
  datasource: ComapnyListDto;
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  // comp = this.getComapnySummary() as any;
    displayedColumns: string[] = ['code', 'companyName'];
  constructor(private http: HttpClient) {

  }

  ngOnInit() {
    // his.companyList.sort = this.sort;
     this.getComapnySummary();
  }
  getComapnySummary() {
    this.http.get('http://localhost:5000/api/values').subscribe(
      (comp) => {
        // this.companyList = new MatTableDataSource( comp as CompanySummary[] );
        // this.comp = comp;
        // console.log(comp);
        this.companyList = comp as MatTableDataSource<ComapnyListDto>;
        // return comp as MatTableDataSource<ComapnyListDto>; // new MatTableDataSource(comp as ComapnyListDto[]);
        this.companyList.sort = this.sort;
      },
      (error) => {
        console.log(error);
      }
    );
  }

}
