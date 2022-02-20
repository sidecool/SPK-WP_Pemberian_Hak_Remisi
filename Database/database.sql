-- MySQL dump 10.13  Distrib 5.7.31, for Win32 (AMD64)
--
-- Host: localhost    Database: dbspk_rinta
-- ------------------------------------------------------
-- Server version	5.7.31-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `t_alternatif`
--

DROP TABLE IF EXISTS `t_alternatif`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_alternatif` (
  `KD_ALTERNATIF` varchar(25) NOT NULL,
  `NM_ALTERNATIF` varchar(250) NOT NULL,
  `PERKARA` text,
  `N_PERKARA` int(11) NOT NULL,
  `PASAL` text,
  `AGAMA` varchar(25) DEFAULT NULL,
  `TGL_TAHAN` date DEFAULT NULL,
  `TGL_PUTUSAN` date DEFAULT NULL,
  `NO_PUTUSAN` text,
  `ASAL_PUTUSAN` text,
  `PERILAKU` text NOT NULL,
  `N_PERILAKU` int(11) NOT NULL,
  `JASA` text NOT NULL,
  `N_JASA` int(11) NOT NULL,
  `MASA_TAHANAN` text NOT NULL,
  `N_MASA_TAHANAN` int(11) NOT NULL,
  PRIMARY KEY (`KD_ALTERNATIF`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_alternatif`
--

LOCK TABLES `t_alternatif` WRITE;
/*!40000 ALTER TABLE `t_alternatif` DISABLE KEYS */;
INSERT INTO `t_alternatif` VALUES ('A001','NAPI 1','Narapidana melakukan tindak pidana umum dan khusus',1,'','Islam','2020-07-13','2020-07-13','','','Buruk',1,'Tidak berpartisipasi dalam kegiatan',1,'Tahun keenam dan seterusnya',6),('A002','NAPI 2','Narapidana melakukan lebih dari satu tindak pidana khusus',2,'','Katholik','2020-07-13','2020-07-13','','','Baik',4,'Ikut menjaga keamanan dalam lingkungan lembaga pemasyarakatan',2,'Tahun ketiga',4),('A003','NAPI 3','Narapidana melakukan lebih dari satu tindak pidana khusus',2,'','Buddha','2019-07-13','2019-07-13','','','Baik',4,'Menghasilkan karya dalam ilmu pengetahuan',4,'Tahun kedua',3),('A004','NAPI 4','Narapidana melakukan satu tindak pidana khusus',3,'','Buddha','2020-07-13','2020-07-13','','','Cukup',3,'Donor darah',3,'Tahun keempat dan kelima',5),('A005','ABC','Narapidana melakukan satu tindak pidana umum',5,'','Buddha','2019-07-18','2019-07-18','','','Kurang Baik',2,'Donor darah',3,'Tahun kedua',3);
/*!40000 ALTER TABLE `t_alternatif` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_kriteria`
--

DROP TABLE IF EXISTS `t_kriteria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_kriteria` (
  `KD_KRITERIA` varchar(25) NOT NULL,
  `NM_KRITERIA` varchar(250) NOT NULL,
  `N_BOBOT` decimal(10,2) NOT NULL,
  `N_ATRIBUT` varchar(25) NOT NULL,
  PRIMARY KEY (`KD_KRITERIA`),
  UNIQUE KEY `NM_KRITERIA` (`NM_KRITERIA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_kriteria`
--

LOCK TABLES `t_kriteria` WRITE;
/*!40000 ALTER TABLE `t_kriteria` DISABLE KEYS */;
INSERT INTO `t_kriteria` VALUES ('C001','PERKARA',20.00,'0'),('C002','PERILAKU',20.00,'0'),('C003','JASA',35.00,'0'),('C004','MASA TAHANAN',25.00,'0');
/*!40000 ALTER TABLE `t_kriteria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_nilai_bobot`
--

DROP TABLE IF EXISTS `t_nilai_bobot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_nilai_bobot` (
  `KD_BOBOT` varchar(25) NOT NULL,
  `KD_ALTERNATIF` varchar(25) NOT NULL,
  `KD_KRITERIA` varchar(25) NOT NULL,
  `N_PENILAIAN_ANGKA` int(11) NOT NULL,
  PRIMARY KEY (`KD_BOBOT`),
  KEY `KD_KRITERIA` (`KD_KRITERIA`),
  KEY `KD_ALTERNATIF` (`KD_ALTERNATIF`),
  CONSTRAINT `t_nilai_bobot_ibfk_1` FOREIGN KEY (`KD_KRITERIA`) REFERENCES `t_kriteria` (`KD_KRITERIA`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `t_nilai_bobot_ibfk_2` FOREIGN KEY (`KD_ALTERNATIF`) REFERENCES `t_alternatif` (`KD_ALTERNATIF`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_nilai_bobot`
--

LOCK TABLES `t_nilai_bobot` WRITE;
/*!40000 ALTER TABLE `t_nilai_bobot` DISABLE KEYS */;
INSERT INTO `t_nilai_bobot` VALUES ('A001C001','A001','C001',1),('A001C002','A001','C002',1),('A001C003','A001','C003',1),('A001C004','A001','C004',6),('A002C001','A002','C001',2),('A002C002','A002','C002',4),('A002C003','A002','C003',2),('A002C004','A002','C004',4),('A003C001','A003','C001',2),('A003C002','A003','C002',4),('A003C003','A003','C003',4),('A003C004','A003','C004',3),('A004C001','A004','C001',3),('A004C002','A004','C002',3),('A004C003','A004','C003',3),('A004C004','A004','C004',5),('A005C001','A005','C001',5),('A005C002','A005','C002',2),('A005C003','A005','C003',3),('A005C004','A005','C004',3);
/*!40000 ALTER TABLE `t_nilai_bobot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_nilai_vektor`
--

DROP TABLE IF EXISTS `t_nilai_vektor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_nilai_vektor` (
  `kd_alternatif` varchar(25) NOT NULL,
  `n_vektor_s` decimal(10,4) NOT NULL DEFAULT '0.0000',
  `n_preferensi` decimal(10,4) NOT NULL DEFAULT '0.0000',
  PRIMARY KEY (`kd_alternatif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_nilai_vektor`
--

LOCK TABLES `t_nilai_vektor` WRITE;
/*!40000 ALTER TABLE `t_nilai_vektor` DISABLE KEYS */;
INSERT INTO `t_nilai_vektor` VALUES ('A001',1.5651,0.2030),('A002',2.7321,0.3550),('A004',3.4087,0.4420);
/*!40000 ALTER TABLE `t_nilai_vektor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_normalisasi_bobot`
--

DROP TABLE IF EXISTS `t_normalisasi_bobot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_normalisasi_bobot` (
  `kd_kriteria` varchar(25) NOT NULL,
  `n_bobot` decimal(10,4) DEFAULT NULL,
  PRIMARY KEY (`kd_kriteria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_normalisasi_bobot`
--

LOCK TABLES `t_normalisasi_bobot` WRITE;
/*!40000 ALTER TABLE `t_normalisasi_bobot` DISABLE KEYS */;
INSERT INTO `t_normalisasi_bobot` VALUES ('C001',0.2000),('C002',0.2000),('C003',0.3500),('C004',0.2500);
/*!40000 ALTER TABLE `t_normalisasi_bobot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_user`
--

DROP TABLE IF EXISTS `t_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_user` (
  `USERNAME` varchar(25) NOT NULL,
  `PASSWORD` varchar(25) NOT NULL,
  `NM_USER` varchar(25) NOT NULL,
  `LEVEL` varchar(25) NOT NULL,
  PRIMARY KEY (`USERNAME`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_user`
--

LOCK TABLES `t_user` WRITE;
/*!40000 ALTER TABLE `t_user` DISABLE KEYS */;
INSERT INTO `t_user` VALUES ('ADMIN','DEMO','NAMA ADMINISTRATOR','0'),('KEPALA','DEMO','NAMA PIMPINAN','1');
/*!40000 ALTER TABLE `t_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `v_laporan`
--

DROP TABLE IF EXISTS `v_laporan`;
/*!50001 DROP VIEW IF EXISTS `v_laporan`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_laporan` AS SELECT 
 1 AS `kd_alternatif`,
 1 AS `nm_alternatif`,
 1 AS `perkara`,
 1 AS `perilaku`,
 1 AS `jasa`,
 1 AS `masa_tahanan`,
 1 AS `n_preferensi`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_laporan`
--

/*!50001 DROP VIEW IF EXISTS `v_laporan`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_laporan` AS select `a`.`kd_alternatif` AS `kd_alternatif`,`b`.`NM_ALTERNATIF` AS `nm_alternatif`,`b`.`PERKARA` AS `perkara`,`b`.`PERILAKU` AS `perilaku`,`b`.`JASA` AS `jasa`,`b`.`MASA_TAHANAN` AS `masa_tahanan`,`a`.`n_preferensi` AS `n_preferensi` from (`t_nilai_vektor` `a` left join `t_alternatif` `b` on((`a`.`kd_alternatif` = convert(`b`.`KD_ALTERNATIF` using utf8mb4)))) order by `a`.`n_preferensi` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-06  1:12:08
