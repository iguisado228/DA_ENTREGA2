-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: da_2entrega
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `erabiltzaileak`
--

DROP TABLE IF EXISTS `erabiltzaileak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `erabiltzaileak` (
  `id_erabiltzailea` int NOT NULL AUTO_INCREMENT,
  `izena` varchar(20) NOT NULL,
  `abizena1` varchar(20) NOT NULL,
  `abizena2` varchar(20) NOT NULL,
  `nan` varchar(9) NOT NULL,
  `jaiotza_data` date NOT NULL,
  `posta_elektronikoa` varchar(45) NOT NULL,
  `telefono_zenbakia` varchar(9) NOT NULL,
  `helbidea` longtext NOT NULL,
  PRIMARY KEY (`id_erabiltzailea`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `erabiltzaileak`
--

LOCK TABLES `erabiltzaileak` WRITE;
/*!40000 ALTER TABLE `erabiltzaileak` DISABLE KEYS */;
INSERT INTO `erabiltzaileak` VALUES (1,'Ane','Garcia','Lopez','12345678A','1990-05-14','ane.garcia@example.com','612345678','Calle Mayor 1, Bilbao'),(2,'Iker','Martinez','Sanchez','23456789B','1988-11-02','iker.mtz@example.com','622345678','Avda Libertad 45, Donostia'),(3,'Miren','Fernandez','Etxeberria','34567890C','1995-07-23','miren.f@example.com','632345678','Calle Arriaga 12, Vitoria'),(4,'Jon','Perez','Agirre','45678901D','1992-03-10','jon.p@example.com','642345678','Plaza Nueva 3, Bilbao'),(5,'Leire','Rodriguez','Ibarra','56789012E','1998-09-30','leire.r@example.com','652345678','Calle Iturribide 8, Gasteiz'),(6,'Unai','Alonso','Garcia','67890123F','1985-12-05','unai.a@example.com','662345678','Calle San Juan 17, Donostia'),(7,'Ainhoa','Lopez','Mendizabal','78901234G','1993-04-18','ainhoa.l@example.com','672345678','Calle Urkijo 4, Bilbao'),(8,'Gaizka','Hernandez','Garate','89012345H','1989-06-27','gaizka.h@example.com','682345678','Calle Estacion 23, Barakaldo'),(9,'Maite','Etxebarria','Uribe','90123456I','1991-08-12','maite.e@example.com','692345678','Avda Gernika 56, Gernika'),(10,'Ander','Agirre','Larrañaga','11223344J','1996-01-20','ander.a@example.com','602345678','Calle Goiri 11, Durango'),(11,'Nerea','Gomez','Landaburu','22334455K','1990-10-08','nerea.g@example.com','611223344','Avda Basagoiti 89, Getxo'),(12,'Asier','Olabarria','Garcia','33445566L','1987-02-19','asier.o@example.com','622334455','Calle Diputacion 99, Bilbao'),(13,'Irati','Urkijo','Perez','44556677M','1994-07-07','irati.u@example.com','633445566','Plaza Berria 10, Gasteiz'),(14,'Xabier','Ruiz','Arrieta','55667788N','1986-11-25','xabier.r@example.com','644556677','Calle Artekale 6, Durango'),(15,'June','Salazar','Fernandez','66778899O','1992-09-09','june.s@example.com','655667788','Calle Elcano 7, Bilbao'),(16,'Markel','Vicente','Lopez','77889900P','1984-12-29','markel.v@example.com','666778899','Calle San Francisco 2, Barakaldo'),(17,'Oihane','Calleja','Martinez','88990011Q','1997-03-15','oihane.c@example.com','677889900','Avda Txorierri 4, Leioa'),(18,'Mikel','Eguren','Santamaria','99001122R','1991-05-22','mikel.e@example.com','688990011','Calle La Paz 33, Vitoria'),(19,'Uxue','Lazaro','Garcia','10111213S','1995-08-19','uxue.l@example.com','699101112','Avda Universitaria 12, Donostia'),(20,'Aitor','Serrano','Iñiguez','12131415T','1989-04-03','aitor.s@example.com','600121314','Calle Santiago 21, Bilbao'),(21,'Amaia','Zabala','Ortega','13141516U','1993-02-11','amaia.z@example.com','611131415','Calle Iturriza 17, Gernika'),(22,'Kepa','Gonzalez','Perez','14151617V','1987-07-30','kepa.g@example.com','622141516','Plaza Euskadi 44, Bilbao'),(23,'Nahia','Jimenez','Uriarte','15161718W','1998-01-25','nahia.j@example.com','633151617','Calle Zabalbide 9, Bilbao'),(24,'Beñat','Ortiz','Sanchez','16171819X','1990-06-06','benat.o@example.com','644161718','Calle Areatza 3, Durango'),(25,'Irune','Marquez','Aranburu','17181920Y','1996-12-02','irune.m@example.com','655171819','Avda Sabino Arana 5, Bilbao'),(26,'Patxi','Pardo','Garcia','18192021Z','1985-09-14','patxi.p@example.com','666181920','Calle Cervantes 13, Vitoria'),(27,'Olatz','Saenz','Martinez','19202122A','1992-11-28','olatz.s@example.com','677192021','Calle Ripa 18, Bilbao'),(28,'Iñigo','Diez','Lopez','20212223B','1988-08-08','inigo.d@example.com','688202122','Avda Autonomia 15, Donostia'),(29,'Eider','Carrasco','Alvarez','21222324C','1994-05-16','eider.c@example.com','699212223','Calle Askatasun 21, Getxo'),(30,'Jokin','Navarro','Salinas','22232425D','1991-01-05','jokin.n@example.com','600222324','Calle Gran Via 1, Bilbao');
/*!40000 ALTER TABLE `erabiltzaileak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `langileak`
--

DROP TABLE IF EXISTS `langileak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `langileak` (
  `id_langilea` int NOT NULL AUTO_INCREMENT,
  `izena` varchar(20) NOT NULL,
  `abizena1` varchar(20) NOT NULL,
  `abizena2` varchar(20) NOT NULL,
  `nan` varchar(9) NOT NULL,
  `jaiotza_data` date NOT NULL,
  `posta_elektronikoa` varchar(45) NOT NULL,
  `telefono_zenbakia` varchar(9) NOT NULL,
  `helbidea` longtext NOT NULL,
  `erabiltzaile_izena` varchar(45) NOT NULL,
  `pasahitza` varchar(45) NOT NULL,
  `arduraduna` tinyint NOT NULL,
  PRIMARY KEY (`id_langilea`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `langileak`
--

LOCK TABLES `langileak` WRITE;
/*!40000 ALTER TABLE `langileak` DISABLE KEYS */;
INSERT INTO `langileak` VALUES (1,'Ane','Garcia','Lopez','12345678A','1990-05-14','ane.garcia@example.com','612345678','Calle Mayor 1, Bilbao','ane.g','pass1234',1),(2,'Iker','Martinez','Sanchez','23456789B','1988-11-02','iker.mtz@example.com','622345678','Avda Libertad 45, Donostia','iker.m','pass2345',0),(3,'Miren','Fernandez','Etxeberria','34567890C','1995-07-23','miren.f@example.com','632345678','Calle Arriaga 12, Vitoria','miren.f','pass3456',0),(4,'Jon','Perez','Agirre','45678901D','1992-03-10','jon.p@example.com','642345678','Plaza Nueva 3, Bilbao','jon.p','pass4567',1),(5,'Leire','Rodriguez','Ibarra','56789012E','1998-09-30','leire.r@example.com','652345678','Calle Iturribide 8, Gasteiz','leire.r','pass5678',0),(6,'Unai','Alonso','Garcia','67890123F','1985-12-05','unai.a@example.com','662345678','Calle San Juan 17, Donostia','unai.a','pass6789',1),(7,'Ainhoa','Lopez','Mendizabal','78901234G','1993-04-18','ainhoa.l@example.com','672345678','Calle Urkijo 4, Bilbao','ainhoa.l','pass7890',0),(8,'Gaizka','Hernandez','Garate','89012345H','1989-06-27','gaizka.h@example.com','682345678','Calle Estacion 23, Barakaldo','gaizka.h','pass8901',1),(9,'Maite','Etxebarria','Uribe','90123456I','1991-08-12','maite.e@example.com','692345678','Avda Gernika 56, Gernika','maite.e','pass9012',0),(10,'Ander','Agirre','Larrañaga','11223344J','1996-01-20','ander.a@example.com','602345678','Calle Goiri 11, Durango','ander.a','pass0123',0),(11,'Nerea','Gomez','Landaburu','22334455K','1990-10-08','nerea.g@example.com','611223344','Avda Basagoiti 89, Getxo','nerea.g','pw1122',1),(12,'Asier','Olabarria','Garcia','33445566L','1987-02-19','asier.o@example.com','622334455','Calle Diputacion 99, Bilbao','asier.o','pw2233',0),(13,'Irati','Urkijo','Perez','44556677M','1994-07-07','irati.u@example.com','633445566','Plaza Berria 10, Gasteiz','irati.u','pw3344',0),(14,'Xabier','Ruiz','Arrieta','55667788N','1986-11-25','xabier.r@example.com','644556677','Calle Artekale 6, Durango','xabier.r','pw4455',1),(15,'June','Salazar','Fernandez','66778899O','1992-09-09','june.s@example.com','655667788','Calle Elcano 7, Bilbao','june.s','pw5566',0),(16,'Markel','Vicente','Lopez','77889900P','1984-12-29','markel.v@example.com','666778899','Calle San Francisco 2, Barakaldo','markel.v','pw6677',1),(17,'Oihane','Calleja','Martinez','88990011Q','1997-03-15','oihane.c@example.com','677889900','Avda Txorierri 4, Leioa','oihane.c','pw7788',0),(18,'Mikel','Eguren','Santamaria','99001122R','1991-05-22','mikel.e@example.com','688990011','Calle La Paz 33, Vitoria','mikel.e','pw8899',1),(19,'Uxue','Lazaro','Garcia','10111213S','1995-08-19','uxue.l@example.com','699101112','Avda Universitaria 12, Donostia','uxue.l','pw9900',0),(20,'Aitor','Serrano','Iñiguez','12131415T','1989-04-03','aitor.s@example.com','600121314','Calle Santiago 21, Bilbao','aitor.s','pw1111',0),(21,'Amaia','Zabala','Ortega','13141516U','1993-02-11','amaia.z@example.com','611131415','Calle Iturriza 17, Gernika','amaia.z','pw2222',1),(22,'Kepa','Gonzalez','Perez','14151617V','1987-07-30','kepa.g@example.com','622141516','Plaza Euskadi 44, Bilbao','kepa.g','pw3333',0),(23,'Nahia','Jimenez','Uriarte','15161718W','1998-01-25','nahia.j@example.com','633151617','Calle Zabalbide 9, Bilbao','nahia.j','pw4444',0),(24,'Beñat','Ortiz','Sanchez','16171819X','1990-06-06','benat.o@example.com','644161718','Calle Areatza 3, Durango','benat.o','pw5555',1),(25,'Irune','Marquez','Aranburu','17181920Y','1996-12-02','irune.m@example.com','655171819','Avda Sabino Arana 5, Bilbao','irune.m','pw6666',0),(26,'Patxi','Pardo','Garcia','18192021Z','1985-09-14','patxi.p@example.com','666181920','Calle Cervantes 13, Vitoria','patxi.p','pw7777',1),(27,'Olatz','Saenz','Martinez','19202122A','1992-11-28','olatz.s@example.com','677192021','Calle Ripa 18, Bilbao','olatz.s','pw8888',0),(28,'Iñigo','Diez','Lopez','20212223B','1988-08-08','inigo.d@example.com','688202122','Avda Autonomia 15, Donostia','inigo.d','pw9999',1),(29,'Eider','Carrasco','Alvarez','21222324C','1994-05-16','eider.c@example.com','699212223','Calle Askatasun 21, Getxo','eider.c','pw0000',0),(30,'Jokin','Navarro','Salinas','22232425D','1991-01-05','jokin.n@example.com','600222324','Calle Gran Via 1, Bilbao','jokin.n','pw1212',0);
/*!40000 ALTER TABLE `langileak` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-03 16:38:13
