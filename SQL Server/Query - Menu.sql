

--CREATE TABLE Menu(
--	MenuID INT PRIMARY KEY IDENTITY(1,1),
--	MenuDescription VARCHAR(100),
--	MenuID_Parent INT REFERENCES Menu(MenuID),
--	MenuURL VARCHAR(100)
--);

--INSERT INTO Menu(MenuDescription, MenuURL) VALUES('Menu 1', '');
--INSERT INTO Menu(MenuDescription, MenuURL) VALUES('Menu 2', '');
--INSERT INTO Menu(MenuDescription, MenuURL) VALUES('Menu 3', '#');


--INSERT INTO Menu(MenuDescription, MenuID_Parent, MenuURL) VALUES('Menu 1.1', 1, '#');

--INSERT INTO Menu(MenuDescription, MenuID_Parent, MenuURL) VALUES('Menu 2.1', 2, '#');
--INSERT INTO Menu(MenuDescription, MenuID_Parent, MenuURL) VALUES('Menu 2.2', 2, '#');



SELECT *
  FROM Menu;

