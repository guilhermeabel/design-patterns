<?php

namespace DesignPatterns\Model;

use MatchaORM;

class Connection
{
    private function __construct()
    {
        MatchaORM\Connection::getInstance(config('connections.' . config('default')));

    }

    public static function connect()
    {
        static $instance = null;
        if (null === $instance) {
            $instance = new static();
        }
        return $instance;
    }
}
