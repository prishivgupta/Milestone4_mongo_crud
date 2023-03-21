import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddProductComponent } from './Pages/Products/add-product/add-product.component';
import { EditProductComponent } from './Pages/Products/edit-product/edit-product.component';
import { ProductsComponent } from './Pages/Products/products/products.component';

const routes: Routes = [
  { path: '', redirectTo:'products', pathMatch:'full' },
  { path:'products', component: ProductsComponent },
  { path:'products/addProduct', component: AddProductComponent },
  { path:'products/editProduct/:id', component: EditProductComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
