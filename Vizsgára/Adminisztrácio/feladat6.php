<?php
require "csatlakozas.php";


$sql='SELECT termekek.nev as `nev`, SUM(mennyiseg) as `mennyiseg` 
      FROM termekek, rendelesek 
      WHERE termekek.id=termekId AND MONTH(DATUM)=2
      GROUP BY termekId
      ORDER BY  2 DESC
      LIMIT 3;';

$result = $conn -> query($sql);

$jason=[];
if ($result->num_rows > 0) {
    while ($row = $result -> fetch_assoc()) {
        //echo $row["nev"]." ".$row["mennyiseg"]." darab<br>";
        array_push($jason,$row);
    }
}
else{
    echo "Nincs étel típusú termék az adatbázisban!";
}

echo json_encode($jason);

$conn->close();