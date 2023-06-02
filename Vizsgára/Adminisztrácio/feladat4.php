<?php
require "csatlakozas.php";

$sql="SELECT COUNT(*) as `db` FROM termekek WHERE etel=1;";

$result = $conn -> query($sql);


$jason=[];

if ($result->num_rows > 0) {
    while ($row = $result -> fetch_assoc()) {
    
        array_push($jason,$row);
    }
}
else{
    echo "Nincs étel típusú termék az adatbázisban!";
}

echo json_encode($jason);

$conn->close();