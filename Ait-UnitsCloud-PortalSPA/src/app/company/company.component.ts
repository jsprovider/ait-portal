import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {

  comapanies: any;
  constructor(private http: HttpClient) {
  }

  ngOnInit() {
    this.getCompany();
  }

  getCompany() {
    this.http.get('http://localhost:5000/api/values').subscribe(data => {
      this.comapanies = data;
    },
    error => {
      console.log(error);
    }
  );
  }

}
