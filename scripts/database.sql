CREATE DATABASE ds8_lab3;

USE ds8_lab3;

-- Creaci�n de la tabla tbl_datoscliente
CREATE TABLE tbl_datoscliente (
    id_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    telefono_movil VARCHAR(15),
    direccion VARCHAR(100) NOT NULL,
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    fecha_modificacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Creaci�n de la tabla tbl_cuenta
CREATE TABLE tbl_cuenta (
    id_cuenta INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT,
    tipo VARCHAR(50) NOT NULL,
    saldo DECIMAL(10, 2) DEFAULT 0.00,
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    fecha_modificacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (id_cliente) REFERENCES tbl_datoscliente(id_cliente)
);

-- Creaci�n de la tabla tbl_movimientos
CREATE TABLE tbl_movimientos (
    id_movimiento INT PRIMARY KEY AUTO_INCREMENT,
    id_cuenta INT NOT NULL,
    deposito DECIMAL(10, 2) DEFAULT 0.00,
    retiro DECIMAL(10, 2) DEFAULT 0.00,
    fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_cuenta) REFERENCES tbl_cuenta(id_cuenta)
);

-- Insertar datos de un cliente
INSERT INTO tbl_datoscliente (nombre, apellido, telefono_movil, direccion)
VALUES ('Juan', 'P�rez', '123456789', 'Calle Principal 123');

-- Insertar otro cliente
INSERT INTO tbl_datoscliente (nombre, apellido, telefono_movil, direccion)
VALUES ('Mar�a', 'Gonz�lez', '987654321', 'Avenida Secundaria 456');

-- Insertar una cuenta asociada al cliente con id_cliente = 1
INSERT INTO tbl_cuenta (id_cliente, tipo, saldo)
VALUES (1, 'Cuenta de Ahorros', 1000.00);

-- Insertar otra cuenta asociada al cliente con id_cliente = 2
INSERT INTO tbl_cuenta (id_cliente, tipo, saldo)
VALUES (2, 'Cuenta Corriente', 500.50);

-- Insertar un movimiento en la cuenta con id_cuenta = 1
INSERT INTO tbl_movimientos (id_cuenta, deposito, retiro)
VALUES (1, 500.00, 0.00);

-- Insertar otro movimiento en la cuenta con id_cuenta = 2
INSERT INTO tbl_movimientos (id_cuenta, deposito, retiro)
VALUES (2, 0.00, 100.25);

--Creaci�n de Procedure selectMovimientos

CREATE PROCEDURE selectMovimientos
    @idCuenta INT
AS
BEGIN
    SELECT *
    FROM tbl_movimientos
    WHERE id_cuenta = @idCuenta;
END;

--Creaci�n de Procedure selectCuentas
CREATE PROCEDURE selectCuentas
    @idCliente INT
AS
BEGIN
    SELECT *
    FROM tbl_cuenta
    WHERE id_cliente = @idCliente;
END;
