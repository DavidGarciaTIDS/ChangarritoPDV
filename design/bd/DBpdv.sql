-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.5.8-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura para tabla dbpruebapdv.brands
CREATE TABLE IF NOT EXISTS `brands` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(150) NOT NULL,
  `description` text NOT NULL DEFAULT '0',
  `logo_path` varchar(200) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.business
CREATE TABLE IF NOT EXISTS `business` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(200) NOT NULL,
  `description` text NOT NULL DEFAULT '',
  `owner_id` int(10) unsigned NOT NULL DEFAULT 0,
  `address` text NOT NULL,
  `city` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.cash_registers
CREATE TABLE IF NOT EXISTS `cash_registers` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL DEFAULT '0',
  `description` text NOT NULL DEFAULT '0',
  `mac_address` varchar(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.cash_register_movements
CREATE TABLE IF NOT EXISTS `cash_register_movements` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cash_register_id` int(10) unsigned NOT NULL,
  `user_id` int(10) unsigned NOT NULL,
  `date` datetime NOT NULL,
  `base_cash` float NOT NULL,
  `cashier_id` int(10) unsigned NOT NULL,
  `cut_results` float NOT NULL,
  `type` enum('Open','Close') NOT NULL DEFAULT 'Close',
  PRIMARY KEY (`id`),
  KEY `FK_cash_register_movements_cash_registers` (`cash_register_id`),
  KEY `FK_cash_register_movements_users` (`user_id`),
  CONSTRAINT `FK_cash_register_movements_cash_registers` FOREIGN KEY (`cash_register_id`) REFERENCES `cash_registers` (`id`),
  CONSTRAINT `FK_cash_register_movements_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.cash_withdrawals
CREATE TABLE IF NOT EXISTS `cash_withdrawals` (
  `id` int(11) NOT NULL,
  `type` enum('Retiro','Emergencia') NOT NULL DEFAULT 'Retiro',
  `cash` double NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.categories
CREATE TABLE IF NOT EXISTS `categories` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(150) NOT NULL,
  `description` text NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.config
CREATE TABLE IF NOT EXISTS `config` (
  `server_ip_address` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.inventory_existence
CREATE TABLE IF NOT EXISTS `inventory_existence` (
  `product_id` int(10) unsigned NOT NULL,
  `existence` float unsigned NOT NULL DEFAULT 0,
  `updated_at` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `last_inventory_mov_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `price` float NOT NULL DEFAULT 0,
  `bar_code` varchar(15) NOT NULL,
  `subcategory_id` int(11) NOT NULL DEFAULT 0,
  `minimal_stock` double NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.sales_details
CREATE TABLE IF NOT EXISTS `sales_details` (
  `ventas_id` int(10) unsigned NOT NULL,
  `producto_id` int(10) unsigned NOT NULL,
  `cantidad` double unsigned NOT NULL DEFAULT 0,
  `precio_especial` double unsigned NOT NULL DEFAULT 0,
  KEY `FK__ventas` (`ventas_id`),
  KEY `FK_sales_details_productos` (`producto_id`),
  CONSTRAINT `FK__ventas` FOREIGN KEY (`ventas_id`) REFERENCES `ventas` (`id`),
  CONSTRAINT `FK_sales_details_productos` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.subcategories
CREATE TABLE IF NOT EXISTS `subcategories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(150) NOT NULL DEFAULT '',
  `lastname` varchar(150) NOT NULL DEFAULT '',
  `mothers_lastname` varchar(150) DEFAULT '',
  `email` varchar(150) NOT NULL DEFAULT '',
  `password` varchar(150) NOT NULL DEFAULT '',
  `type` enum('admin','cashier') NOT NULL DEFAULT 'cashier',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.users_movs_log
CREATE TABLE IF NOT EXISTS `users_movs_log` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int(10) unsigned NOT NULL,
  `type` enum('Caja','Invent','Prod','Retiro') NOT NULL DEFAULT 'Caja',
  `details` text DEFAULT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`),
  KEY `FK__users` (`user_id`),
  CONSTRAINT `FK__users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla dbpruebapdv.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fechasHoras` datetime NOT NULL,
  `numCaja` int(10) unsigned NOT NULL DEFAULT 0,
  `numElementos` int(10) unsigned NOT NULL DEFAULT 0,
  `montoTotal` int(10) unsigned NOT NULL DEFAULT 0,
  `FolioTicket` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
