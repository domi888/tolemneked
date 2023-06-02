
document.getElementById("F4").onclick=function(){
    ajax("feladat4.php","GET",null,function(adatok){
        document.getElementById("feladat4").innerHTML=adatok[0].db+" darab étel van az adatbázisban";
    });
};

document.getElementById("F5").onclick=function(){
    ajax("feladat5.php","GET",null,function(adatok){

        let Desszertek="";
        for(let desszert of adatok){
            Desszertek+=desszert.nev+" "+desszert.ar+" Ft<br>";
        }


        document.getElementById("feladat5").innerHTML=Desszertek;

    });
};

document.getElementById("F6").onclick=function(){
    ajax("feladat6.php","GET",null,function(adatok){

        let mennyisegek="";
        for(let adat of adatok){
            mennyisegek+= adat.nev+" "+adat.mennyiseg+" darab<br>";
        }


        document.getElementById("feladat6").innerHTML=mennyisegek;

    });
};


function ajax(url,method,body,callback){

    let xmlhhtp = new XMLHttpRequest();

    xmlhhtp.onreadystatechange=function(){
        if (this.readyState==4 && this.status==200) {
            callback(JSON.parse(this.responseText));
        }
    }


    xmlhhtp.open(method,url,true);
    xmlhhtp.send(body);
}