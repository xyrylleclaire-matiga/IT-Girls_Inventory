-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2025 at 05:55 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbladmin_users`
--

CREATE TABLE `tbladmin_users` (
  `admin_id` int(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `Middle_Name` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `assigned_department` enum('Bookstore Department','Property Department','','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbladmin_users`
--

INSERT INTO `tbladmin_users` (`admin_id`, `username`, `LastName`, `FirstName`, `Middle_Name`, `Password`, `assigned_department`) VALUES
(67899876, 'Morales', 'Morales', 'Maria Dionesia', 'L', 'DIONESIA', 'Bookstore Department'),
(12344321, 'Marasigan', 'Morales', 'Reynaldo', 'M', 'REYNALDO', 'Property Department');

-- --------------------------------------------------------

--
-- Table structure for table `tblstockrequests`
--

CREATE TABLE `tblstockrequests` (
  `request_id` int(11) NOT NULL,
  `uniform_id` int(50) NOT NULL,
  `requested_by` int(50) NOT NULL,
  `approved_by` int(50) NOT NULL,
  `quantity_requested` datetime NOT NULL,
  `request_date` datetime NOT NULL,
  `approval_date` datetime NOT NULL,
  `status` enum('pending','approved','rejected','completed') NOT NULL,
  `remarks` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbluniformlogs`
--

CREATE TABLE `tbluniformlogs` (
  `log_id` int(11) NOT NULL,
  `uniform_id` int(50) NOT NULL,
  `action` enum('added','updated','sold','restocked') NOT NULL,
  `quantity_change` int(50) NOT NULL,
  `user_id` varchar(50) NOT NULL,
  `action_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbluniforms`
--

CREATE TABLE `tbluniforms` (
  `uniform_id` int(11) NOT NULL,
  `item_name` varchar(50) NOT NULL,
  `category` enum('School Uniform','PE Uniform','Corporate Attire') NOT NULL,
  `level` enum('Kindergarten','Elementary','Junior High','Senior High','College') NOT NULL,
  `gender` enum('Male','Female','Unisex') NOT NULL,
  `size` enum('Extra Small','Small','Medium','Large','Extra Large','2XL','3XL','4XL','5XL','6XL') NOT NULL,
  `stock_quantity` int(50) NOT NULL,
  `price` decimal(50,0) NOT NULL,
  `status` enum('Available','Out of Stock','Critical','') NOT NULL,
  `date_added` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluniforms`
--

INSERT INTO `tbluniforms` (`uniform_id`, `item_name`, `category`, `level`, `gender`, `size`, `stock_quantity`, `price`, `status`, `date_added`) VALUES
(1, 'Slacks', 'School Uniform', 'College', 'Male', 'Extra Small', 0, 470, 'Available', '2025-10-07 11:28:08'),
(2, 'Polo', 'School Uniform', 'College', 'Male', 'Extra Small', 8, 470, 'Available', '2025-10-07 11:29:07'),
(3, 'Skirt', 'School Uniform', 'College', 'Female', 'Extra Small', 14, 470, 'Available', '2025-10-07 11:30:01'),
(4, 'Polo', 'School Uniform', 'College', 'Female', 'Extra Small', 10, 470, 'Available', '2025-10-07 11:30:31'),
(5, 'Slacks', 'School Uniform', 'College', 'Male', 'Small', 10, 470, 'Available', '2025-10-07 11:30:31'),
(6, 'Polo', 'School Uniform', 'College', 'Male', 'Small', 10, 470, 'Available', '2025-10-07 11:31:23'),
(7, 'Skirt', 'School Uniform', 'College', 'Female', 'Small', 10, 470, 'Available', '2025-10-07 11:31:23'),
(8, 'Polo', 'School Uniform', 'College', 'Female', 'Small', 10, 470, 'Available', '2025-10-07 11:31:23'),
(9, 'Slacks', 'School Uniform', 'College', 'Male', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23'),
(10, 'Polo', 'School Uniform', 'College', 'Male', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23'),
(11, 'Skirt', 'School Uniform', 'College', 'Female', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23'),
(12, 'Polo', 'School Uniform', 'College', 'Female', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23'),
(13, 'Slacks', 'School Uniform', 'College', 'Male', 'Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(14, 'Polo', 'School Uniform', 'College', 'Male', 'Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(15, 'Skirt', 'School Uniform', 'College', 'Female', 'Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(16, 'Polo', 'School Uniform', 'College', 'Female', 'Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(17, 'Slacks', 'School Uniform', 'College', 'Male', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(18, 'Polo', 'School Uniform', 'College', 'Male', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(19, 'Skirt', 'School Uniform', 'College', 'Female', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(20, 'Polo', 'School Uniform', 'College', 'Female', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23'),
(21, 'Slacks', 'School Uniform', 'College', 'Male', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(22, 'Polo', 'School Uniform', 'College', 'Male', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(23, 'Skirt', 'School Uniform', 'College', 'Female', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(24, 'Polo', 'School Uniform', 'College', 'Female', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(25, 'Slacks', 'School Uniform', 'College', 'Male', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(26, 'Polo', 'School Uniform', 'College', 'Male', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(27, 'Skirt', 'School Uniform', 'College', 'Female', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(28, 'Polo', 'School Uniform', 'College', 'Female', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(29, 'Slacks', 'School Uniform', 'College', 'Male', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(30, 'Polo', 'School Uniform', 'College', 'Male', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(31, 'Skirt', 'School Uniform', 'College', 'Female', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(32, 'Polo', 'School Uniform', 'College', 'Female', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(33, 'Slacks', 'School Uniform', 'College', 'Male', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(34, 'Polo', 'School Uniform', 'College', 'Male', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(35, 'Skirt', 'School Uniform', 'College', 'Female', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(36, 'Polo', 'School Uniform', 'College', 'Female', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(37, 'Slacks', 'School Uniform', 'College', 'Male', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(38, 'Polo', 'School Uniform', 'College', 'Male', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(39, 'Skirt', 'School Uniform', 'College', 'Female', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(40, 'Polo', 'School Uniform', 'College', 'Female', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23'),
(41, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:44:03'),
(42, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:44:03'),
(43, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 11:44:03'),
(44, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 11:44:03'),
(45, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 11:44:03'),
(46, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 11:44:03'),
(47, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 11:44:03'),
(48, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 11:44:03'),
(49, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:44:03'),
(50, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:44:03'),
(51, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(52, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(53, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(54, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(55, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(56, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(57, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(58, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(59, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(60, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 11:44:03'),
(61, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:50:08'),
(62, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:50:08'),
(63, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:51:03'),
(64, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:51:03'),
(65, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58'),
(66, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58'),
(67, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58'),
(68, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58'),
(69, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58'),
(70, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58'),
(71, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58'),
(72, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58'),
(73, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(74, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(75, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(76, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(77, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(78, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(79, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(80, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58'),
(81, 'Slacks', 'School Uniform', 'Senior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(82, 'Polo', 'School Uniform', 'Senior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(83, 'Skirt', 'School Uniform', 'Senior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(84, 'Polo', 'School Uniform', 'Senior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(85, 'Slacks', 'School Uniform', 'Senior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(86, 'Polo', 'School Uniform', 'Senior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(87, 'Skirt', 'School Uniform', 'Senior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(88, 'Polo', 'School Uniform', 'Senior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(89, 'Slacks', 'School Uniform', 'Senior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(90, 'Polo', 'School Uniform', 'Senior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(91, 'Skirt', 'School Uniform', 'Senior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(92, 'Polo', 'School Uniform', 'Senior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(93, 'Slacks', 'School Uniform', 'Senior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(94, 'Polo', 'School Uniform', 'Senior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(95, 'Skirt', 'School Uniform', 'Senior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(96, 'Polo', 'School Uniform', 'Senior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(97, 'Slacks', 'School Uniform', 'Senior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(98, 'Polo', 'School Uniform', 'Senior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(99, 'Skirt', 'School Uniform', 'Senior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(100, 'Polo', 'School Uniform', 'Senior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58'),
(101, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:01:04'),
(102, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:01:04'),
(103, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:06:39'),
(104, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:06:39'),
(105, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:06:39'),
(106, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:06:39'),
(107, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:06:39'),
(108, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:06:39'),
(109, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:06:39'),
(110, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:06:39'),
(111, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(112, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(113, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(114, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(115, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(116, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(117, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(118, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(119, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(120, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:06:39'),
(121, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(122, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(123, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(124, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(125, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(126, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(127, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(128, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35'),
(129, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35'),
(130, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35'),
(131, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35'),
(132, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35'),
(133, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(134, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(135, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(136, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(137, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(138, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(139, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(140, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35'),
(141, 'Slacks', 'School Uniform', 'Junior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(142, 'Polo', 'School Uniform', 'Junior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(143, 'Skirt', 'School Uniform', 'Junior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(144, 'Polo', 'School Uniform', 'Junior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(145, 'Slacks', 'School Uniform', 'Junior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(146, 'Polo', 'School Uniform', 'Junior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(147, 'Skirt', 'School Uniform', 'Junior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(148, 'Polo', 'School Uniform', 'Junior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(149, 'Slacks', 'School Uniform', 'Junior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(150, 'Polo', 'School Uniform', 'Junior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(151, 'Skirt', 'School Uniform', 'Junior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(152, 'Polo', 'School Uniform', 'Junior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(153, 'Slacks', 'School Uniform', 'Junior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(154, 'Polo', 'School Uniform', 'Junior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(155, 'Skirt', 'School Uniform', 'Junior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(156, 'Polo', 'School Uniform', 'Junior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(157, 'Slacks', 'School Uniform', 'Junior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(158, 'Polo', 'School Uniform', 'Junior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(159, 'Skirt', 'School Uniform', 'Junior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(160, 'Polo', 'School Uniform', 'Junior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35'),
(161, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:18:22'),
(162, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:18:22'),
(163, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:18:22'),
(164, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:18:22'),
(165, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:18:22'),
(166, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:18:22'),
(167, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:18:22'),
(168, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:18:22'),
(169, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:18:22'),
(170, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:18:22'),
(171, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(172, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(173, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(174, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(175, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(176, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(177, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(178, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(179, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(180, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:18:22'),
(181, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(182, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(185, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(186, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(187, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(188, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(189, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(190, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54'),
(191, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54'),
(192, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54'),
(193, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54'),
(194, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54'),
(195, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(196, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(197, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(198, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(199, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(200, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(201, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(202, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54'),
(203, 'Blouse', 'School Uniform', 'Elementary', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(204, 'Jumper', 'School Uniform', 'Elementary', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(205, 'Polo', 'School Uniform', 'Elementary', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(206, 'Pants', 'School Uniform', 'Elementary', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(207, 'Blouse', 'School Uniform', 'Elementary', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(208, 'Jumper', 'School Uniform', 'Elementary', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(209, 'Polo', 'School Uniform', 'Elementary', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(210, 'Pants', 'School Uniform', 'Elementary', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(211, 'Blouse', 'School Uniform', 'Elementary', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(212, 'Jumper', 'School Uniform', 'Elementary', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(213, 'Polo', 'School Uniform', 'Elementary', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(214, 'Pants', 'School Uniform', 'Elementary', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(215, 'Blouse', 'School Uniform', 'Elementary', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(216, 'Jumper', 'School Uniform', 'Elementary', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(217, 'Polo', 'School Uniform', 'Elementary', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(218, 'Pants', 'School Uniform', 'Elementary', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(219, 'Blouse', 'School Uniform', 'Elementary', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(220, 'Jumper', 'School Uniform', 'Elementary', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(221, 'Polo', 'School Uniform', 'Elementary', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(222, 'Pants', 'School Uniform', 'Elementary', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54'),
(223, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '', 10, 450, 'Available', '2025-10-07 12:30:34'),
(224, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:32:30'),
(225, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:32:30'),
(226, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Small', 10, 470, 'Available', '2025-10-07 12:32:30'),
(227, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Small', 10, 470, 'Available', '2025-10-07 12:32:30'),
(228, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Medium', 10, 470, 'Available', '2025-10-07 12:32:30'),
(229, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Medium', 10, 470, 'Available', '2025-10-07 12:32:30'),
(230, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Large', 10, 470, 'Available', '2025-10-07 12:32:30'),
(231, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Large', 10, 470, 'Available', '2025-10-07 12:32:30'),
(232, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:32:30'),
(233, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:32:30'),
(234, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '2XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(235, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '2XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(236, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '3XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(237, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '3XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(238, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '4XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(239, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '4XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(240, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '5XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(241, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '5XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(242, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '6XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(243, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '6XL', 10, 470, 'Available', '2025-10-07 12:32:30'),
(244, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:41:52'),
(245, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:41:52'),
(246, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:41:52'),
(247, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Small', 10, 470, 'Available', '2025-10-07 12:41:52'),
(248, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:41:52'),
(249, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Medium', 10, 470, 'Available', '2025-10-07 12:41:52'),
(250, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:41:52'),
(251, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Large', 10, 470, 'Available', '2025-10-07 12:41:52'),
(252, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:41:52'),
(253, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:41:52'),
(254, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:41:52'),
(255, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '2XL', 10, 470, 'Available', '2025-10-07 12:41:52'),
(256, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:41:52'),
(257, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '3XL', 10, 470, 'Available', '2025-10-07 12:41:52'),
(258, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:41:52'),
(259, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '4XL', 10, 470, 'Available', '2025-10-07 12:41:52'),
(260, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:41:52'),
(261, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '5XL', 10, 470, 'Available', '2025-10-07 12:41:52'),
(262, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:41:52'),
(263, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '6XL', 10, 470, 'Available', '2025-10-07 12:41:52'),
(264, 'Polo', 'School Uniform', 'Kindergarten', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:46:08'),
(265, 'Slacks', 'School Uniform', 'Kindergarten', 'Male', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:46:08'),
(266, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:46:08'),
(267, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:46:08'),
(268, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:46:08'),
(269, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Small', 10, 470, 'Available', '2025-10-07 12:46:08'),
(270, 'Polo', 'School Uniform', 'Kindergarten', '', 'Small', 10, 450, 'Available', '2025-10-07 12:46:08'),
(271, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Small', 10, 470, 'Available', '2025-10-07 12:46:08'),
(272, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:46:08'),
(273, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Medium', 10, 470, 'Available', '2025-10-07 12:46:08'),
(274, 'Polo', 'School Uniform', 'Kindergarten', '', 'Medium', 10, 450, 'Available', '2025-10-07 12:46:08'),
(275, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Medium', 10, 470, 'Available', '2025-10-07 12:46:08'),
(276, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:46:08'),
(277, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Large', 10, 470, 'Available', '2025-10-07 12:46:08'),
(278, 'Polo', 'School Uniform', 'Kindergarten', '', 'Large', 10, 450, 'Available', '2025-10-07 12:46:08'),
(279, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Large', 10, 470, 'Available', '2025-10-07 12:46:08'),
(280, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:46:08'),
(281, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:46:08'),
(282, 'Polo', 'School Uniform', 'Kindergarten', '', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:46:08'),
(283, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:46:08'),
(284, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(285, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '2XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(286, 'Polo', 'School Uniform', 'Kindergarten', '', '2XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(287, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '2XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(288, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(289, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '3XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(290, 'Polo', 'School Uniform', 'Kindergarten', '', '3XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(291, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '3XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(292, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(293, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '4XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(294, 'Polo', 'School Uniform', 'Kindergarten', '', '4XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(295, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '4XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(296, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(297, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '5XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(298, 'Polo', 'School Uniform', 'Kindergarten', '', '5XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(299, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '5XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(300, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(301, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '6XL', 10, 470, 'Available', '2025-10-07 12:46:08'),
(302, 'Polo', 'School Uniform', 'Kindergarten', '', '6XL', 10, 450, 'Available', '2025-10-07 12:46:08'),
(303, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '6XL', 10, 470, 'Available', '2025-10-07 12:46:08');

-- --------------------------------------------------------

--
-- Table structure for table `tbluniformsales`
--

CREATE TABLE `tbluniformsales` (
  `sale_id` int(11) NOT NULL,
  `uniform_id` int(50) NOT NULL,
  `user_id` int(50) NOT NULL,
  `quantity` int(50) NOT NULL,
  `total_price` decimal(50,0) NOT NULL,
  `sale_date` datetime NOT NULL,
  `payment_status` enum('Pending','Cancelled','Paid','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `user_id` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` enum('Admin','Student') NOT NULL,
  `email` varchar(50) NOT NULL,
  `status` enum('Active','Deactivated') NOT NULL,
  `attempts` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`user_id`, `last_name`, `first_name`, `middle_name`, `password`, `role`, `email`, `status`, `attempts`) VALUES
('1878-23', 'Saguban', 'Bianca Jeanelle', 'Tuazon', 'SAGUBAN', 'Student', 'biancaa@gmail.com', 'Active', 3),
('1881-23', 'Obis', 'Francine Mei', 'Ramirez', 'OBIS', 'Student', 'francine@gmail.com', 'Active', 3),
('2008-23', 'Cenardo', 'Vernalyn', 'Equing', 'CENARDO', 'Student', 'vernalyn@gmail.com', 'Active', 3),
('2097-23', 'Matiga', 'Xyrylle Claire', 'Lasin', 'MATIGA', 'Student', 'xyryllematiga@gmail.com', 'Active', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pullouts`
--

CREATE TABLE `tbl_pullouts` (
  `PulloutId` int(11) NOT NULL,
  `uniform_id` int(11) NOT NULL,
  `PulloutReason` enum('Damaged','Misprinted') NOT NULL,
  `Date` datetime NOT NULL,
  `Quantity` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pullouts`
--

INSERT INTO `tbl_pullouts` (`PulloutId`, `uniform_id`, `PulloutReason`, `Date`, `Quantity`) VALUES
(4, 0, 'Misprinted', '2025-10-22 00:00:00', 2),
(5, 0, 'Misprinted', '2025-10-22 00:00:00', 1),
(6, 0, 'Damaged', '2025-10-22 00:00:00', 1),
(7, 0, 'Misprinted', '2025-10-22 00:00:00', 1),
(8, 8, 'Misprinted', '2025-10-22 00:00:00', 1),
(9, 8, 'Misprinted', '2025-10-22 00:00:00', 1),
(10, 8, '', '0000-00-00 00:00:00', 0),
(11, 8, '', '0000-00-00 00:00:00', 0),
(12, 8, '', '0000-00-00 00:00:00', 0),
(13, 6, 'Damaged', '2025-10-22 00:00:00', 1),
(14, 10, 'Damaged', '2025-10-22 17:42:07', 2),
(15, 4, 'Misprinted', '2025-10-22 17:47:13', 0),
(16, 1, 'Damaged', '2025-10-22 18:54:11', 2),
(17, 1, 'Damaged', '2025-10-22 18:58:48', 11),
(18, 1, 'Damaged', '2025-10-22 19:05:35', 11),
(19, 1, 'Damaged', '2025-10-22 19:05:35', 2),
(20, 1, 'Damaged', '2025-10-22 19:09:16', 11),
(21, 1, 'Damaged', '2025-10-22 19:09:16', 2),
(22, 1, 'Misprinted', '2025-10-22 19:14:59', 12),
(23, 1, 'Misprinted', '2025-10-22 19:14:59', 2),
(24, 1, 'Misprinted', '2025-10-22 20:39:45', 1),
(25, 1, 'Misprinted', '2025-10-22 20:39:45', 4),
(26, 1, 'Damaged', '2025-10-22 20:43:04', 2),
(27, 2, 'Damaged', '2025-10-22 20:49:31', 2),
(28, 3, 'Damaged', '2025-10-22 21:00:04', -2),
(29, 4, 'Misprinted', '2025-10-22 21:00:36', 0),
(30, 3, 'Damaged', '2025-10-22 21:03:03', -2),
(31, 3, 'Damaged', '2025-10-22 21:03:27', 0),
(32, 1, 'Damaged', '2025-10-23 11:17:19', 1),
(33, 1, 'Misprinted', '2025-10-23 11:18:07', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblstockrequests`
--
ALTER TABLE `tblstockrequests`
  ADD PRIMARY KEY (`request_id`);

--
-- Indexes for table `tbluniformlogs`
--
ALTER TABLE `tbluniformlogs`
  ADD PRIMARY KEY (`log_id`);

--
-- Indexes for table `tbluniforms`
--
ALTER TABLE `tbluniforms`
  ADD PRIMARY KEY (`uniform_id`);

--
-- Indexes for table `tbluniformsales`
--
ALTER TABLE `tbluniformsales`
  ADD PRIMARY KEY (`sale_id`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `tbl_pullouts`
--
ALTER TABLE `tbl_pullouts`
  ADD PRIMARY KEY (`PulloutId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblstockrequests`
--
ALTER TABLE `tblstockrequests`
  MODIFY `request_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbluniformlogs`
--
ALTER TABLE `tbluniformlogs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbluniforms`
--
ALTER TABLE `tbluniforms`
  MODIFY `uniform_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=304;

--
-- AUTO_INCREMENT for table `tbluniformsales`
--
ALTER TABLE `tbluniformsales`
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_pullouts`
--
ALTER TABLE `tbl_pullouts`
  MODIFY `PulloutId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
