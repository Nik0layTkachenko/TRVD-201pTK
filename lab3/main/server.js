const express = require('express');
const mustacheExpress = require('mustache-express');
const bodyParser = require('body-parser');
const path = require('path');

const app = express();
const PORT = 3000;

const productController = require('./controllers/productController');

app.engine('mustache', mustacheExpress());
app.set('view engine', 'mustache');
app.set('views', path.join(__dirname, 'views'));

app.use(bodyParser.urlencoded({ extended: true }));
app.use(express.static(path.join(__dirname, 'public')));

app.get('/', productController.showAllProducts);
app.get('/product/:id', productController.showProductById);

app.listen(PORT, () => console.log(`Сервер запущено на http://localhost:${PORT}`));
