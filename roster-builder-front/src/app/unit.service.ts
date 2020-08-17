import { Unit } from './Entities/Unit';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, retry } from 'rxjs/operators';
import { throwError } from 'rxjs/internal/observable/throwError';

@Injectable({
  providedIn: 'root'
})
export class UnitService {
  private url = 'http://localhost:5000/api/Units/';

constructor(private http: HttpClient) { }

// : Observable<Unit>
getHero(name: string): Observable<Unit>{
  return this.http.get<Unit>(this.url+name).pipe(
    retry(3), // retry a failed request up to 3 times
    catchError(this.handleError)// then handle the error
  );
}
private handleError(error: HttpErrorResponse) {
  if (error.error instanceof ErrorEvent) {
    // A client-side or network error occurred. Handle it accordingly.
    console.error('An error occurred:', error.error.message);
  } else {
    // The backend returned an unsuccessful response code.
    // The response body may contain clues as to what went wrong,
    console.error(
      `Backend returned code ${error.status}, ` +
      `body was: ${error.error}`);
  }
  // return an observable with a user-facing error message
  return throwError(
    'Something bad happened; please try again later.');
};
}
