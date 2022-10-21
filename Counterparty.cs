using System;

namespace ConsoleApp1
{
    internal class Counterparty
    {
        //Сделать класс описывающий контрагента, данный класс должен содержать общие атрибуты которые есть у физического и юридического лица,
        //например идентификатор,
        //БИН / ИИН,
        //дата создания,

        private int ID;
        private string BIN_IIN;
        private DateTime DateCreate;

        public Counterparty(int id, string bin_iin, DateTime dateCreate)
        {
            ID = id;
            BIN_IIN = bin_iin;
            DateCreate = dateCreate;
        }
    }
}
