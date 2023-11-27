DELIMITER //

CREATE PROCEDURE selectMovimientosPorCliente(
    IN cliente_id INT 
)
BEGIN
    SELECT m.id_movimiento, c.tipo, m.deposito, m.retiro, m.fecha
    FROM tbl_movimientos m
    INNER JOIN tbl_cuenta c ON m.id_cuenta = c.id_cuenta
    WHERE c.id_cliente = cliente_id;
END //

DELIMITER ;
