<?php

namespace DesignPatterns\View;

class UserView
{
    public static function index()
    {
        $users = \Model\User::all();

        foreach ($users as $user) {
            echo $user->name . '<br>';
        }
    }
}
