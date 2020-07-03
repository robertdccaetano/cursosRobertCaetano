<?php

require __DIR__."/../vendor/autoload.php";
//
//use CoffeeCode\DataLayer\Connect;
//
//$con = Connect::getInstance();  
//
//$erro = Connect::getError();
//
//if ( $erro ) {
//    echo $erro->getMessage();
//    die;
//}
//
//$query = $con->query("SELECT * FROM users");
//echo "<pre>",
//var_dump($query->fetchAll()),
//        "</pre>";

use Source\Models\User;
use Source\Models\Address;

$user = new User();

$list = $user->find()->fetch(true);

//echo "<pre>",
//var_dump($list),
//    "</pre>";
//        

/** @var $userItem User*/
echo "<pre>";
foreach ($list as $userItem) {
    var_dump($userItem->data());
    
    foreach ($userItem->addresses() as $address) {
        var_dump($address->data());
    }
}
echo "</pre>";