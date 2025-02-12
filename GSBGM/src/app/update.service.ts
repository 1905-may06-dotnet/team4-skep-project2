import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { Observer, Observable, fromEventPattern, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UpdateService {
  baseUrl:string="https://gsbgma.azurewebsites.net/api/Profile/";
  constructor(
    public http: HttpClient,
  ) { }
  UpdateUserHTTPPut(URL:string,User:any): Observable<HttpResponse<string>> {
    return this.http.put(this.baseUrl+URL, User, {headers: new HttpHeaders({'Content-Type': 'application/json'}), observe: 'response'})
  .pipe(
    catchError(this.handleError('UdateUser',User))
  );
  }
  UpdateUserHTTPPost(URL:string,User:any): Observable<HttpResponse<string>> {
    return this.http.post(this.baseUrl+URL, User, {headers: new HttpHeaders({'Content-Type': 'application/json'}), observe: 'response'})
  .pipe(
    catchError(this.handleError('UdateUser',User))
  );
  }
  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  
  }
}
