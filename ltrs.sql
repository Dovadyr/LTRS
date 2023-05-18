-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2023 at 10:05 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ltrs`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(8) NOT NULL,
  `Username` varchar(120) NOT NULL,
  `Password` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `Username`, `Password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `funds`
--

CREATE TABLE `funds` (
  `fundID` int(1) NOT NULL,
  `fundName` varchar(50) NOT NULL,
  `fundAmount` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `funds`
--

INSERT INTO `funds` (`fundID`, `fundName`, `fundAmount`) VALUES
(1, 'Capital', 10500.00),
(2, 'Borrowed', 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `loans`
--

CREATE TABLE `loans` (
  `transacID` int(10) NOT NULL,
  `accID` int(10) NOT NULL,
  `transacDate` date NOT NULL,
  `duedate` date NOT NULL,
  `principal` int(90) NOT NULL,
  `interest` int(90) NOT NULL,
  `total` int(90) NOT NULL,
  `loanstatus` varchar(50) NOT NULL,
  `approvalNotice` int(1) NOT NULL,
  `finishNotice` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loans`
--

INSERT INTO `loans` (`transacID`, `accID`, `transacDate`, `duedate`, `principal`, `interest`, `total`, `loanstatus`, `approvalNotice`, `finishNotice`) VALUES
(7, 1, '2023-05-01', '2023-05-31', 1000, 100, 1100, 'Approved', 1, 0),
(8, 6, '2023-05-31', '0000-00-00', 1234, 62, 1296, 'Approved', 1, 0),
(9, 6, '0000-00-00', '0000-00-00', 1234, 62, 1296, 'Pending', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(12) NOT NULL,
  `Fname` varchar(50) NOT NULL,
  `Sname` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phonenum` varchar(11) NOT NULL,
  `bdate` date NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `Fname`, `Sname`, `email`, `phonenum`, `bdate`, `password`) VALUES
(1, 'Admin', 'Admin', 'admin@ltrs.manage', '09000000000', '0000-00-00', 'admin'),
(2, 'sadass', 'sadadad', 'xlander213231', '123123123', '0000-00-00', 'Dsadasd'),
(3, 'Try', 'Try', 'sadkalds', '0', '2000-02-01', 'asdasdas'),
(5, 'ALEX', 'MOJICA', 'hotdog@gmail.com', '09777777777', '2000-01-01', '1234'),
(6, 'TEST', 'CLIENT', 'test@gmail.com', '09775656544', '2001-04-01', 'test'),
(7, 'ALEXANDER', 'MOJICA', 'mojicaschool@y.com', '09774775655', '2000-05-01', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `paymentID` int(10) NOT NULL,
  `transacID` int(10) NOT NULL,
  `payDate` date NOT NULL,
  `amount` decimal(8,2) NOT NULL,
  `verified` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`paymentID`, `transacID`, `payDate`, `amount`, `verified`) VALUES
(1, 1, '2023-05-01', 23123.00, NULL),
(2, 1, '2023-05-02', 2000.00, NULL),
(3, 1, '2023-05-01', 2000.03, NULL),
(4, 1, '2023-04-29', 999.99, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `funds`
--
ALTER TABLE `funds`
  ADD PRIMARY KEY (`fundID`);

--
-- Indexes for table `loans`
--
ALTER TABLE `loans`
  ADD PRIMARY KEY (`transacID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`paymentID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `funds`
--
ALTER TABLE `funds`
  MODIFY `fundID` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `loans`
--
ALTER TABLE `loans`
  MODIFY `transacID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `paymentID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
