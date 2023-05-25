INSERT INTO
    movies (title, genre, rating, release_date)
VALUES
    (
        'The Shawshank Redemption',
        'Drama',
        9.3,
        '1994-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        'The Godfather',
        'Crime',
        9.2,
        '1972-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        'The Dark Knight',
        'Action',
        9.1,
        '2008-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        'Lay''s',
        'Biography',
        9.3,
        '1993-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        'Pulp Fiction',
        'Drama',
        8.9,
        '1994-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        'Forrest Gump',
        'Romance',
        8.8,
        '1994-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        'Fight Club',
        'Drama',
        8.8,
        '1999-5-5 00:00:00+00' :: timestamp with time zone
    );

INSERT INTO
    orders (total_price)
VALUES
    (10),
    (20);

INSERT INTO
    order_movie (order_id, movie_id, order_date)
VALUES
    (
        1,
        2,
        '2021-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        1,
        3,
        '2021-5-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        2,
        2,
        '2021-8-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        2,
        6,
        '2021-8-5 00:00:00+00' :: timestamp with time zone
    ),
    (
        2,
        7,
        '2021-8-5 00:00:00+00' :: timestamp with time zone
    );