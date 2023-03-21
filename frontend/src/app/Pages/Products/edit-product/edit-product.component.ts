import { Component } from '@angular/core';
import { Product } from 'src/app/Models/Product';
import { ProductService } from 'src/app/Services/Product/product.service';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css']
})
export class EditProductComponent {

  // creating a parametrized constructor to call the product service, location and active route
  constructor(private productService: ProductService, private location: Location, private route: ActivatedRoute) {}

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
  editProduct(product: Product): void {
    this.productService.updateProduct(product).subscribe(() => this.goBack());
  }

  // function to get a particular product by id and storing its data in product object
  getProductById(): void {
    const id = String(this.route.snapshot.paramMap.get('id'));
    this.productService.getProductById(id).subscribe(product => {
      this.product.id = product.id,
      this.product.productName = product.productName,
      this.product.productDescription = product.productDescription,
      this.product.productPrice = product.productPrice,
      this.product.category = product.category
    });
  }

  // calling the ngOnit lificycle hook to load get product by id
  ngOnInit(): void {
    this.getProductById();
  }
}
