using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace App3
{
    class Week
    {
        private string Date { set; get; }
        private string Gname { set; get; }
        private string Parity { set; get; } //четность
        private string Modified { set; get; }
        private Dictionary<string, List<Event>> Events { set; get; }
        public Week(String html)
        {
            //parsing
            Regex pattern = new Regex(@"^Расписание\ занятий\ группы\:\ (?<Gname>.+)\((?<Parity>.+)\ неделя\).*");
			//MatchCollection matches = Regex.Matches(html, pattern);
			Match match = pattern.Match(html);
			this.Gname = match.Groups["Gname"].Value;
			this.Parity = match.Groups["Parity"].Value;
			/*foreach (Match match in matches)
            {
                this.Events["monday"].Add(new Event(match.ToString()));
            } */
		}
        public static void Test()
        {
            string data = @"Расписание занятий группы: ИМИ-БА-ИВТ-19-1(четная неделя)  на 30-04-2020<b>, изм.: 30.01.2020 12:11:50</b> 
< table class=""rasp table table-hover table-bordered"">
<thead>
<tr class=""error"">
	<th>Время</th>
	<th>Название предмета</th>
	<th>Преподаватель</th>
	<th>Аудитория</th>
	<th>Доп.информация</th>
</tr>
</thead><tbody><tr class=""error""><th colspan = 5 > ПОНЕДЕЛЬНИК 27 апреля 2020</th></tr>	<tr class=""success"">
		<td>08:00-09:35</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Иностранный язык');return false"">Иностранный язык</a> (практика) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('833801972');return false"" > Ноговицына О.С.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('324','КФЕН');return false"" > 324 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>09:50-11:25</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Русский язык и культура речи');return false"">Русский язык и культура речи</a>(лекция) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('724772');return false"">Печетова Н.Ю.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('461','КФЕН');return false"" > 461 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>11:40-13:15</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Иностранный язык');return false"">Иностранный язык</a> (практика) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('721967');return false"" > Максимов А.А.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('451','КФЕН');return false"" > 451 КФЕН</a></td>
		<td> С 09.01 по 30.06 	<tr  class=""success"">
		<td>14:00-15:35</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Основы программирования');return false"">Основы программирования</a> (Лабораторная работа) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('724228');return false"" > Васильева Н.В.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('432','КФЕН');return false"" > 432 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>14:00-15:35</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Введение в сквозные цифровые технологии');return false"">Введение в сквозные цифровые технологии</a>(Лабораторная работа) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('723382');return false"">Николаева Н.В.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('436','КФЕН');return false"" > 436 КФЕН</a></td>
		<td> С 27.01 по 02.06 <tr class=""error""><th colspan = 5 > ВТОРНИК 28 апреля 2020</th></tr>	<tr class=""success"">
		<td>11:40-13:15</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Основы программирования');return false"">Основы программирования</a> (лекция) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('724071');return false"" > Павлов А.В.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('328','КФЕН');return false"" > 328 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>14:00-15:35</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Русский язык и культура речи');return false"">Русский язык и культура речи</a>(практика) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('724772');return false"">Печетова Н.Ю.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('555','КФЕН');return false"" > 555 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>15:50-17:25</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Основы права');return false"">Основы права</a> (лекция) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('349562300');return false"" > Егорова У.П.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('461','КФЕН');return false"" > 461 КФЕН</a></td>
		<td> С 27.01 по 02.06 <tr class=""error""><th colspan = 5 > СРЕДА 29 апреля 2020</th></tr>	<tr class=""success"">
		<td>09:50-11:25</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Введение в сквозные цифровые технологии');return false"">Введение в сквозные цифровые технологии</a>(лекция) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('723382');return false"">Николаева Н.В.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('328','КФЕН');return false"" > 328 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>11:40-13:15</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Физическая культура и спорт');return false"">Физическая культура и спорт</a> (практика) <br>Ядреев В. В - ПМГ (Тренажерный зал ск "" )</td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('725506');return false"" > Протодьяконова М.Н.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('Спортивный','Юность');return false"" > Спортивный Юность</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>14:00-15:35</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Дискретная математика');return false"">Дискретная математика</a> (практика) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('725080');return false"" > Попов О.Н.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('447','КФЕН');return false"" > 447 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>15:50-17:25</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Введение в сквозные цифровые технологии');return false"">Введение в сквозные цифровые технологии</a>(Лабораторная работа) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('723382');return false"">Николаева Н.В.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('432','КФЕН');return false"" > 432 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>15:50-17:25</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Основы программирования');return false"">Основы программирования</a> (Лабораторная работа) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('724228');return false"" > Васильева Н.В.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('430','КФЕН');return false"" > 430 КФЕН</a></td>
		<td> С 27.01 по 02.06 <tr class=""error""><th colspan = 5 > ЧЕТВЕРГ 30 апреля 2020</th></tr>	<tr class=""success"">
		<td>09:50-11:25</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Математика');return false"">Математика</a>(практика) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('91677040');return false"">Григорьева А.И.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('455','КФЕН');return false"" > 455 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>11:40-13:15</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Математика');return false"">Математика</a>(лекция) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('91677040');return false"">Григорьева А.И.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('326','КФЕН');return false"" > 326 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>14:00-15:35</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Иностранный язык');return false"">Иностранный язык</a> (практика) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('833801972');return false"" > Ноговицына О.С.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('324','КФЕН');return false"" > 324 КФЕН</a></td>
		<td> С 27.01 по 02.06 <tr class=""error""><th colspan = 5 > ПЯТНИЦА  1 мая 2020</th></tr>	<tr class=""success"">
		<td>11:40-13:15</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Иностранный язык');return false"">Иностранный язык</a> (практика) </td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('721967');return false"" > Максимов А.А.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('451','КФЕН');return false"" > 451 КФЕН</a></td>
		<td> С 09.01 по 30.06 <tr class=""error""><th colspan = 5 > СУББОТА  2 мая 2020</th></tr>	<tr class=""success"">
		<td>08:00-09:35</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Организация вычислительных систем');return false"">Организация вычислительных систем</a>(Лабораторная работа) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('721745');return false"">Лыткин С.Д.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('436','КФЕН');return false"" > 436 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>09:50-11:25</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Организация вычислительных систем');return false"">Организация вычислительных систем</a>(практика) </td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showprep('721745');return false"">Лыткин С.Д.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('533','КФЕН');return false"" > 533 КФЕН</a></td>
		<td> С 27.01 по 02.06 	<tr  class=""success"">
		<td>11:40-13:15</td>
		<td><a href = ""\error.html"" target=""_blank"" onclick=""showdis('Физическая культура и спорт');return false"">Физическая культура и спорт</a> (практика) <br>Ядреев В. В - ПМГ (Тренажерный зал ск "" )</td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showprep('725506');return false"" > Протодьяконова М.Н.</a></td>
		<td><a href = ""\error.html"" target= ""_blank"" onclick= ""showaud('Спортивный','Юность');return false"" > Спортивный Юность</a></td>
		<td> С 27.01 по 02.06 </table>	";
			Week W = new Week(data);
			if (W.Gname != "ИМИ-БА-ИВТ-19-1")
			{
				Console.WriteLine("error name group");
			}
		}
           
    }
}