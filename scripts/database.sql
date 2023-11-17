CREATE DATABASE ds8_lab3;

USE ds8_lab3;

-- Creación de la tabla tbl_datoscliente
CREATE TABLE tbl_datoscliente (
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    telefono_movil VARCHAR(15),
    direccion VARCHAR(100) NOT NULL,
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    fecha_modificacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Creación de la tabla tbl_cuenta
CREATE TABLE tbl_cuenta (
    id_cuenta INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT,
    tipo VARCHAR(50) NOT NULL,
    saldo DECIMAL(10, 2) DEFAULT 0.00,
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    fecha_modificacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (id_cliente) REFERENCES tbl_datoscliente(id_cliente)
);

-- Creación de la tabla tbl_movimientos
CREATE TABLE tbl_movimientos (
    id_movimiento INT PRIMARY KEY AUTO_INCREMENT,
    id_cuenta INT NOT NULL,
    deposito DECIMAL(10, 2) DEFAULT 0.00,
    retiro DECIMAL(10, 2) DEFAULT 0.00,
    fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_cuenta) REFERENCES tbl_cuenta(id_cuenta)
);
