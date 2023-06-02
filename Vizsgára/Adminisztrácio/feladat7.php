<?php
require "csatlakozas.php";


$sql='SELECT ROUND(SUM(ar*mennyiseg),0) as `brutto`, ROUND(afakulcs/(1+afakulcs)*SUM(ar*mennyiseg),0) as `afa` 
      FROM termekek, rendelesek 
      WHERE termekek.id=termekId;';

$result = $conn -> query($sql);

//print_r($result);
if ($result->num_rows > 0) {
    while ($row = $result -> fetch_assoc()) {
        echo "A teljes bevétel: ".$row["brutto"]." Ft.\nAz ÁFA értéke: ".$row["afa"]." Ft.";
        
    }
}
else{
    echo "Nincs étel típusú termék az adatbázisban!";
}


$conn->close();