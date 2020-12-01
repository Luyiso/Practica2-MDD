use practica2bda;

SELECT color 
FROM product 
WHERE color like 'Black';

SELECT orderdate
FROM salesorderheader 
WHERE orderdate BETWEEN CAST('2012-01-01' AS DATE) AND CAST('2013-12-31' AS DATE);

SELECT customerid,firstname,lastname
FROM customer;

SELECT salesorderID 
FROM salesorderheader 
WHERE orderdate BETWEEN CAST('2012-01-01' AS DATE) AND CAST('2013-12-31' AS DATE);

SELECT DISTINCT p.productid
FROM salesorderdetail s , product p 
WHERE color like 'Black'

AND salesorderID IN (SELECT salesorderID 
					FROM salesorderheader 
					WHERE orderdate BETWEEN CAST('2012-01-01' AS DATE) AND CAST('2013-12-31' AS DATE));
                    
/* order by numprod DESC, Lastname ASC;*/


/*no sirve hace falta calcular bien el numero de productos comprados en todo el año 2012 y 2013*/
SELECT SQL_NO_CACHE DISTINCT COUNT(p.productid) as numprod,  lastName ,  firstName , orderdate , color , c.territoryid
		FROM customer c,product p ,salesorderdetail sd ,salesorderheader sh
        WHERE sd.salesorderID = sh.salesorderID 
		AND sd.productid = p.productid
        AND c.customerid = sh.customerid
        AND p.color like 'Black'
        AND sh.orderdate BETWEEN CAST('2012-01-01' AS DATE) AND CAST('2013-12-31' AS DATE)
        AND c.territoryid IN (SELECT territoryid FROM salesterritory WHERE tname like 'Canada') 
        GROUP BY c.lastName 
		ORDER BY numprod DESC, Lastname ASC ;


/*
la media de productos diferentes comprados por todos los clientes (en todos los años).
*/
SELECT avg(numprodtodos) 
	FROM (SELECT DISTINCT COUNT(salesorderdetail.ProductID) as numprodtodos
			FROM salesorderdetail
			GROUP BY ProductID) tbtemp;

/* prueba que devuelve 0 , XD*/
SELECT SQL_NO_CACHE DISTINCT COUNT(p.productid) as numprod,  lastName ,  firstName , orderdate , color , c.territoryid
		FROM customer c,product p ,salesorderdetail sd ,salesorderheader sh
        WHERE sd.salesorderID = sh.salesorderID 
		AND sd.productid = p.productid
        AND c.customerid = sh.customerid
        AND p.color like 'Black'
        AND sh.orderdate BETWEEN CAST('2012-01-01' AS DATE) AND CAST('2013-12-31' AS DATE)
        AND c.territoryid IN (SELECT territoryid FROM salesterritory WHERE tname like 'Canada') 
        GROUP BY c.lastName 
        HAVING numprod > (SELECT avg(numprodtodos) 
							FROM (SELECT DISTINCT COUNT(salesorderdetail.ProductID) as numprodtodos
									FROM salesorderdetail
									GROUP BY ProductID) tbtemp)
		ORDER BY numprod DESC, Lastname ASC ;


/* SIGUE RETORNANDO 0 PERO CON INNER JOIN ES MAS EFICIENTE , XD*/
SELECT SQL_NO_CACHE DISTINCT COUNT(p.productid) as numprod,  lastName ,  firstName , orderdate , color , c.territoryid
		FROM salesorderdetail sd 
        INNER JOIN salesorderheader sh ON sd.salesorderID = sh.salesorderID 
		INNER JOIN product p ON sd.productid = p.productid
        INNER JOIN customer c ON  c.customerid = sh.customerid
        WHERE p.color like 'Black'
        AND sh.orderdate BETWEEN CAST('2012-01-01' AS DATE) AND CAST('2013-12-31' AS DATE)
        AND c.territoryid IN (SELECT territoryid FROM salesterritory WHERE tname like 'Canada') 
        GROUP BY c.lastName 
		HAVING numprod > (SELECT avg(numprodtodos) 
							FROM (SELECT DISTINCT COUNT(salesorderdetail.ProductID) as numprodtodos
									FROM salesorderdetail
									GROUP BY ProductID) tbtemp)
		ORDER BY numprod DESC, Lastname ASC ;


/* esta es la primera consulta del año pasado imagino que algo se tendra que parecer

SELECT SQL_NO_CACHE DISTINCT p2.lastName ,  p2.firstName ,  p2.edad , COUNT(p1.player_id) as numero_partidos
		FROM player p2,player_stats p1
        WHERE p1.player_id = p2.player_id AND (p2.nationality LIKE "CAN" OR p2.nationality LIKE "USA")
        GROUP BY p1.player_id , p2.lastName , p2.firstName ,  p2.edad 
		HAVING numero_partidos > (SELECT avg(numpartidos) 
									FROM (SELECT DISTINCT COUNT(player_stats.player_id) as numpartidos
										FROM player_stats
										GROUP BY player_id) tbtemp)
		ORDER BY edad DESC, lastName ASC ,firstName ASC ;

*/
