DELIMITER //

CREATE TRIGGER actualizarSaldoDespuesDeMovimiento
AFTER INSERT ON tbl_movimientos
FOR EACH ROW
BEGIN
    DECLARE monto DECIMAL(10, 2);
    
    -- Obtener el monto del movimiento recién insertado
    IF NEW.deposito > 0 THEN
        SET monto = NEW.deposito;
    ELSE
        SET monto = NEW.retiro;
    END IF;

    -- Actualizar el saldo en tbl_cuenta según el tipo de operación
    IF NEW.deposito > 0 THEN
        UPDATE tbl_cuenta SET saldo = saldo + monto WHERE id_cuenta = NEW.id_cuenta;
    ELSE
        UPDATE tbl_cuenta SET saldo = saldo - monto WHERE id_cuenta = NEW.id_cuenta;
    END IF;
END//

DELIMITER ;