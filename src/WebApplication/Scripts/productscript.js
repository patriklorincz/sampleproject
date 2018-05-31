var ProductsModel = function ProductsViewModel() {
  var self = this;
  self.productsUri = 'api/products/availableproducts';

  self.products = ko.observableArray();

  self.warehouse = ko.observable('');
  self.category = ko.observable('');

  function ajaxHelper(uri, method) {
    return $.ajax({
      type: method,
      url: uri,
      dataType: 'json',
      contentType: 'application/json',
      data : {
        warehouse : self.warehouse,
        category: self.category
      }
    });
  }

  self.getProducts = function() {
    ajaxHelper(self.productsUri, 'GET').done(function (data) {
      self.products(data);
    });
  }

  self.getProducts();
}

ko.applyBindings(new ProductsModel());