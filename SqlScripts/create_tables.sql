CREATE TABLE IF NOT EXISTS movies (
    movie_id serial PRIMARY KEY,
    title VARCHAR(30) NOT NULL,
    genre VARCHAR(30) NOT NULL,
    rating NUMERIC(2, 1) NOT NULL,
    release_date TIMESTAMP WITH TIME ZONE NOT NULL
);

CREATE TABLE IF NOT EXISTS orders (
    order_id serial PRIMARY KEY,
    total_price NUMERIC(5, 1) NOT NULL
);

CREATE TABLE IF NOT EXISTS order_movie (
    order_id INT NOT NULL,
    movie_id INT NOT NULL,
    order_date TIMESTAMP WITH TIME ZONE NOT NULL,
    PRIMARY KEY(order_id, movie_id),
    FOREIGN KEY(order_id) REFERENCES orders(order_id),
    FOREIGN KEY(movie_id) REFERENCES movies(movie_id)
);