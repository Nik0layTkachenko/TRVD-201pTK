const fs = require('fs');
const path = require('path');

const productsPath = path.join(__dirname, '../data/products.json');

exports.showAllProducts = (req, res) => {
  const products = JSON.parse(fs.readFileSync(productsPath, 'utf-8'));
  res.render('index', { products });
};

exports.showProductById = (req, res) => {
  const products = JSON.parse(fs.readFileSync(productsPath, 'utf-8'));
  const product = products.find(p => p.id == req.params.id);
  if (!product) return res.status(404).send('Товар не знайдено');
  res.render('product', { product });
};
