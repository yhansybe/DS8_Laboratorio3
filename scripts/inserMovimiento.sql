DELIMITER //

CREATE PROCEDURE agregarMovimiento(
    IN idCuenta INT,
    IN monto DECIMAL(10, 2),
    IN tipoOperacion VARCHAR(10)
)
BEGIN
    IF tipoOperacion = 'deposito' THEN
        INSERT INTO tbl_movimientos (id_cuenta, deposito, fecha)
        VALUES (idCuenta, monto, CURRENT_TIMESTAMP);
    ELSEIF tipoOperacion = 'retiro' THEN
        INSERT INTO tbl_movimientos (id_cuenta, retiro, fecha)
        VALUES (idCuenta, monto, CURRENT_TIMESTAMP);
    ELSE
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Tipo de operación no válido';
    END IF;
END//

DELIMITER ;
