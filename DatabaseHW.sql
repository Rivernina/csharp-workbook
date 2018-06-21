CREATE TABLE toys (id INT, toy VARCHAR(50), 
             manufacturer VARCHAR(50), country VARCHAR(10), model VARCHAR(10), price FLOAT, stock INT);
      
INSERT INTO toys (id, toy, manufacturer, country, model, price, stock)
VALUES(101, "Barbie Amelia Earhart Doll", "Fisher-Price", "USA", "SE54673", 29.99, 28),
      (102, "LEGO Star Wars Kessel Run Millennium Falcon", "LEGO", "USA", "75212", 169.95, 37),
      (103, "Num Noms Lipgloss Truck Craft Kit", "Toys 'N' Tech", "China", "T54630", 49.99, 20),
      (104, "Shopkins Super Mall Playset", "Irwin Toy", "China", "20934", 79.97, 19),
      (105, "Bratz CIY Sweet Shoppe Activity Playset", "J. W. Spear & Sons", "Pakistan", "02030", 17.50, 6),
      (106, "Disney Princess Royal Shimmer Ariel Doll", "Pedigree Dolls & Toys", "China", "8Y09", 6.97, 11),
      (107, "Tinker Bell & Terence Tea Party Playset", "Toywiz", "India", "45-098", 89.99, 14),
      (108, "Flipzee Girl Zoey Snuggly Bear", "FLIPAZOO", "China", "564547361", 14.84, 2),
      (109, "Aurora World 7"" Garfield Plush", "Kid Brands, Inc.", "USA", "F098", 8.05, 17),
      (110, "Squishy Toy, Slow Rising Simulated Milk Box", " Sassy, Inc.", "USA", "W-980", 9.13, 29);

CREATE TABLE aisles (aisle_id INT, name VARCHAR(50));
INSERT INTO aisles (aisle_id, name)
VALUES (101, "Age Group: Child"),
       (102, "Age Group: 10 to 16 Years"),
       (103, "Age Group: 3 to 4 Years"),
       (104, "Age Group: 5 to 6 Years"),
       (105, "Age Group: 7 to 8 Years"),
       (106, "Age Group: 9 to 10 Years"),
       (107, "Age Group: 11 to 12 Years"),
       (108, "Age Group: 10 to 14 Years"),
       (109, "Age Group: 2 to 3 Years"),
       (110, "Age Group: 1 to 2 Years");

_________________________________________________________________________

SELECT toy, aisle_id, name AS , stock
FROM aisles JOIN toys ON (aisle_id = id)
GROUP BY toy                 
