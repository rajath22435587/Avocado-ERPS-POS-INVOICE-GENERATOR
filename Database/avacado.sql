-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 16, 2018 at 10:16 AM
-- Server version: 5.7.23
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `avacado`
--
CREATE DATABASE IF NOT EXISTS `avacado` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `avacado`;

-- --------------------------------------------------------

--
-- Table structure for table `login_credentials`
--

CREATE TABLE IF NOT EXISTS `login_credentials` (
  `Sl.No` int(8) NOT NULL,
  `Username` varchar(32) NOT NULL,
  `Password` varchar(32) NOT NULL,
  `RememberMe` tinyint(1) DEFAULT NULL,
  `JobAssigned_1` varchar(32) DEFAULT NULL,
  `JobAssigned_2` varchar(32) DEFAULT NULL,
  `JobAssigned_3` varchar(32) DEFAULT NULL,
  `Admin` tinyint(1) DEFAULT NULL,
  `LastLogin` datetime(6) NOT NULL,
  `uid` int(32) NOT NULL,
  PRIMARY KEY (`Sl.No`)
) ENGINE=MEMORY DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
