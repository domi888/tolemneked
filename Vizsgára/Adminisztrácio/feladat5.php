<?php
require "csatlakozas.php";


$sql='SELECT termekek.nev as `nev`, ar FROM termekek, kategoriak WHERE kategoriaId=kategoriak.id AND kategoriak.nev LIKE "Desszertek";';

$result = $conn -> query($sql);

//print_r($result);
$jason=[];
if ($result->num_rows > 0) {
    while ($row = $result -> fetch_assoc()) {
        //echo $row["nev"]." ".$row["ar"]." Ft\n";
        array_push($jason,$row);
    }
}
else{
    echo "Nincs desszert az adatbázisban!";
}

echo json_encode($jason);

$conn->close();