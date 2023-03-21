import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from 'src/app/Models/Product';
import { catchError, Observable, throwError } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  // url of the json server
  baseUrl: string = "https://localhost:7256/api/Product/";

  // function to handle the error
  handleError(error: HttpErrorResponse) {
    if(error.error instanceof ErrorEvent) {
      console.error('An error message occured:', error.error.message);
    } else {
      console.error(error.error)
    }
    return throwError('Something happened, please try again');
  }

  // get all products service 

  getAllProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl + 'GetAllProducts').pipe(catchError(this.handleError))
  }

  // get a particular product by id service

  getProductById(id: string): Observable<any> {
    return this.http.get<any>(this.baseUrl + `GetProductById/${id}`).pipe(catchError(this.handleError))
  }

  // add an product service

  addProduct(product: Product): Observable<any> {
    return this.http.post<Product>(this.baseUrl + 'AddProduct', product).pipe(catchError(this.handleError))
  }

  // update a particular product service

  updateProduct(product: Product): Observable<any> {
    return this.http.put<Product>(this.baseUrl + 'UpdateProduct', product).pipe(catchError(this.handleError))
  }

  // delete an product service

  deleteProduct(id: string): Observable<any> {
    return this.http.delete<any>(this.baseUrl + `DeleteProduct?id=${id}`).pipe(catchError(this.handleError))
  }
}

