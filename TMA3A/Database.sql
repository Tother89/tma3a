
DROP DATABASE IF EXISTS TMA3A;

CREATE DATABASE TMA3A;

USE TMA3A;

DROP TABLE IF EXISTS Slideshow;

CREATE TABLE Slideshow
(
	ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	URL VARCHAR(100),
	Description VARCHAR(200)
);

INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/banffhotsprings.jpg", "Cave at Banff Hot Springs");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/banffmountains.jpg", "Consolation Lakes in Banff");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/calmlake.jpg", "Two Jack Lake in Banff");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/waterfall.jpg", "Crescent Falls in Nordegg");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/mallows.jpg", "Camping and Roasting Marshmallows");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/foggydowntown.jpg", "Foggy Downtown Edmonton");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/folkfestsunset.jpg", "Edmonton Folk Fest 2018 - Gallagher Park");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/cryptlakewaterfall.jpg", "Crypt Lake Waterfall");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/cryptlake.jpg", "Crypt Lake");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/crypthike.jpg", "Hiking Crypt Lake Trail");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/watertonlake.jpg", "Waterton Lake");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/misswatertonrainbow.jpg", "Miss Waterton Rain and Rainbows");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/rivercanoe.jpg", "North Saskatchewan River Canoeing");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/vancouverbay.jpg", "Stanley Park - Vancouver");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2//vancouverbridge.jpg", "Lions Gate Bridge- Vancouver");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/vancouverflowers.jpg", "Flowers in Queen Elizabeth Park");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/hike.jpg", "Gray Creek Hiking");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/crab.jpg", "Crab on a Beach");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/coastalforest.jpg", "Hidden Grove - Sechelt");
INSERT INTO Slideshow (URL, Description) VALUES ("../Images/Part2/bcferry.jpg", "BC Ferry Approaching Langdale");


DROP TABLE IF EXISTS Computers;

CREATE TABLE Computers
(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Title VARCHAR(100) NOT NULL,
	Price DOUBLE NOT NULL,
	ImageUrl VARCHAR(100) NOT NULL
);

INSERT INTO Computers (Title, Price, ImageUrl) VALUES("Surface Pro", 1049.99, "../Images/Computers/surfacepro.png");
INSERT INTO Computers (Title, Price, ImageUrl) VALUES("Macbook Pro", 1529.99, "../Images/Computers/macbook.png");
INSERT INTO Computers (Title, Price, ImageUrl) VALUES("HP Notebook", 299.99, "../Images/Computers/hp.png");


DROP TABLE IF EXISTS Parts;
CREATE TABLE Parts
(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Price DOUBLE NOT NULL,
	PartType VARCHAR(100) NOT NULL,
	ImageUrl VARCHAR(100) NOT NULL
);

INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Acer 27 in. 75Hz", 189.99, "Display", "../Images/Parts/acer27.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("BenQ 24 in. 144 Hz", 259.99, "Display", "../Images/Parts/benq24.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Dell 24 in. 60 Hz", 139.99, "Display", "../Images/Parts/dell24.png");

INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("HDD 500GB", 51.98, "Drive", "../Images/Parts/hdd500gb.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("HDD 1TB", 64.99, "Drive", "../Images/Parts/hdd1tb.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("HDD 2TB", 84.99, "Drive", "../Images/Parts/hdd2tb.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("SSD 256GB", 79.99, "Drive", "../Images/Parts/ssd256gb.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("SSD 500GB", 129.99, "Drive", "../Images/Parts/ssd500gb.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("SSD 1TB", 199.99, "Drive", "../Images/Parts/ssd1tb.png");

INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("4 GB", 34.99, "RAM", "../Images/Parts/ram4gb.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("8 GB", 54.99, "RAM", "../Images/Parts/ram8gb.png");
INSERT INTO Parts(Name, Price, PartType, ImageUrl) VALUES("16 GB", 119.99, "RAM", "../Images/Parts/ram16.png");
INSERT INTO Parts(Name, Price, PartType, ImageUrl) VALUES("32 GB", 284.99, "RAM", "../Images/Parts/ram32.png");

INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("AMD Ryzen 3", 124.99, "CPU", "../Images/Parts/amd3.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("AMD Ryzen 5", 229.99, "CPU", "../Images/Parts/amd5.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("AMD Ryzen 7", 329.99, "CPU", "../Images/Parts/amd7.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Intel i3", 159.99, "CPU", "../Images/Parts/i3.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Intel i5", 259.99, "CPU", "../Images/Parts/i5.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Intel i7", 479.99, "CPU", "../Images/Parts/i7.png");

INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Windows 7 Home Premium", 19.36, "OS", "../Images/Parts/win7.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Mac OS X 10.6 Snow Leopard", 27.99, "OS", "../Images/Parts/macOS.png");
INSERT INTO Parts (Name, Price, PartType, ImageUrl) VALUES("Windows 10 Home", 38.71, "OS", "..Images/Parts/win10.png");