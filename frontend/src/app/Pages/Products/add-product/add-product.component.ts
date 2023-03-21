import { Component } from '@angular/core';
import { Product } from 'src/app/Models/Product';
import { ProductService } from 'src/app/Services/Product/product.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent {

  // creating a parametrized constructor to call the product service, location
  constructor(private productService: ProductService, private location: Location) {}

  // creating an product object to store data
  product: Product = {
    id: '',
    productName: '',
    productDescription: '',
    productPrice: 0,
    category: ''
  };

  // function to go back to previous page
  goBack(): void {
    this.location.back();
  }

  // function to call edit product from service layer
  addProduct(product: Product): void {
    this.productService.addProduct(product).subscribe(() => this.goBack());
  }

}
