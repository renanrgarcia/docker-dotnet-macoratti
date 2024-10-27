CREATE DATABASE productsdb;

USE productsdb;

DROP TABLE IF EXISTS `Products`;

CREATE TABLE `Products` (
    `ProductId` INT AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Category` varchar(50) NOT NULL,
    `Price` decimal(10,2) NOT NULL,
    PRIMARY KEY (`ProductId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES `Products` WRITE;
    INSERT INTO `Products` VALUES(1,'Kayak','Watersports',275.0);
    INSERT INTO `Products` VALUES(2,'Lifejacket','Watersports',48.95);
    INSERT INTO `Products` VALUES(3,'Soccer Ball','Soccer',19.50);
UNLOCK TABLES;

