import {DataSource} from '@angular/cdk/collections';
import {ComapnyListDto} from './Comapny-list-Dto';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
export class CompanyListDatasource implements DataSource<ComapnyListDto> {

    constructor(private http: HttpClient) {
        super();
      }

    disconnect() { }

    connect(): Observable<ComapnyListDto[]> {
        return this.http.get('http://localhost:5000/api/values') as Observable<ComapnyListDto[]> ;
    }
}
