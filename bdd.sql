CREATE DATABASE projet_stive;

USE projet_stive;

CREATE TABLE supplier(
   supplier_id INT,
   name VARCHAR(50) NOT NULL,
   adress INT NOT NULL,
   zipcode VARCHAR(50) NOT NULL,
   city VARCHAR(50) NOT NULL,
   email VARCHAR(50) NOT NULL,
   PRIMARY KEY(supplier_id)
);

CREATE TABLE product_category(
   category_id INT,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(100) NOT NULL,
   PRIMARY KEY(category_id)
);

CREATE TABLE product_brand(
   brand_id INT,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(100) NOT NULL,
   PRIMARY KEY(brand_id)
);

CREATE TABLE role(
   role_id INT,
   code VARCHAR(50) NOT NULL,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(50) NOT NULL,
   PRIMARY KEY(role_id)
);

CREATE TABLE orders_status(
   status_id INT,
   name VARCHAR(50) NOT NULL,
   PRIMARY KEY(status_id)
);

CREATE TABLE product(
   product_id INT,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(50) NOT NULL,
   price DECIMAL(15,2) NOT NULL,
   image VARCHAR(200) NOT NULL,
   creation_date DATE NOT NULL,
   quantity INT NOT NULL,
   supplier_id INT NOT NULL,
   category_id INT NOT NULL,
   brand_id INT NOT NULL,
   PRIMARY KEY(product_id),
   FOREIGN KEY(supplier_id) REFERENCES supplier(supplier_id),
   FOREIGN KEY(category_id) REFERENCES product_category(category_id),
   FOREIGN KEY(brand_id) REFERENCES product_brand(brand_id)
);

CREATE TABLE web_user(
   user_id INT,
   email VARCHAR(50) NOT NULL,
   phone VARCHAR(10) NOT NULL,
   password VARCHAR(50) NOT NULL,
   firstname VARCHAR(50) NOT NULL,
   lastname VARCHAR(50) NOT NULL,
   role_id INT NOT NULL,
   PRIMARY KEY(user_id),
   FOREIGN KEY(role_id) REFERENCES role(role_id)
);

CREATE TABLE orders(
   orders_id INT,
   price DECIMAL(15,2) NOT NULL,
   order_date DATETIME NOT NULL,
   quantity INT NOT NULL,
   status_id INT NOT NULL,
   user_id INT NOT NULL,
   PRIMARY KEY(orders_id),
   FOREIGN KEY(status_id) REFERENCES orders_status(status_id),
   FOREIGN KEY(user_id) REFERENCES web_user(user_id)
);

CREATE TABLE discount(
   discount_id INT,
   name VARCHAR(50) NOT NULL,
   discount_percent DECIMAL(15,2) NOT NULL,
   active BOOLEAN NOT NULL,
   product_id INT NOT NULL,
   PRIMARY KEY(discount_id),
   FOREIGN KEY(product_id) REFERENCES product(product_id)
);

CREATE TABLE customer_address(
   adress_id INT,
   city VARCHAR(50) NOT NULL,
   zipcode INT NOT NULL,
   address VARCHAR(50) NOT NULL,
   firstname VARCHAR(50) NOT NULL,
   lastname VARCHAR(50) NOT NULL,
   user_id INT NOT NULL,
   PRIMARY KEY(adress_id),
   FOREIGN KEY(user_id) REFERENCES web_user(user_id)
);

CREATE TABLE orders_detail(
   product_id INT,
   orders_id INT,
   price DECIMAL(15,2) NOT NULL,
   quantity INT NOT NULL,
   PRIMARY KEY(product_id, orders_id),
   FOREIGN KEY(product_id) REFERENCES product(product_id),
   FOREIGN KEY(orders_id) REFERENCES orders(orders_id)
);