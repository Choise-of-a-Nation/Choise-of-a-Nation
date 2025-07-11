﻿using Assets.Scripts.Clasess;
using Assets.Scripts.Clasess.Chois;
using Assets.Scripts.Clasess.Levels;
using Assets.Scripts.Clasess.Profile;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Initilization
{
    public class StartInit : MonoBehaviour
    {
        public List<Parametrs> InitParam()
        {
            return new List<Parametrs>()
            {
                new Parametrs()
                {
                    Id = 0,
                    Name = "Підтримка еліти",
                    Description = "Підтримка еліти — це ключовий параметр, що визначає рівень впливу соціальної та політичної еліти на армію. Висока підтримка еліти забезпечує армії кращу організацію, більш ефективне командування та доступ до передових тактичних і технологічних нововведень. Еліта може сприяти фінансуванню армії, забезпеченню ресурсами та вербуванню елітних підрозділів, що в свою чергу підвищує боєздатність і мобільність війська.\r\n\r\nОднак низький рівень підтримки еліти може призвести до погіршення морального стану військ, зменшення фінансування і навіть до виникнення внутрішніх конфліктів, що ускладнює ефективне керування армією. Враховуючи її значення, важливо підтримувати баланс між вимогами еліти та інтересами народу, аби не дати можливість розколоти внутрішню стабільність держави.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 1,
                    Name = "Підтримка армії",
                    Description = "Підтримка армії – цей параметр визначає рівень моральної та матеріальної підтримки, яку отримує ваша армія від населення, уряду та інших союзників. Високий рівень підтримки значно підвищує бойовий дух солдатів, мотивуючи їх до подвигів на полі бою, покращуючи ефективність у боях та знижуючи ймовірність дезертирства. Навпаки, низька підтримка може призвести до зниження морального стану, що негативно впливатиме на швидкість руху армії, точність атак і здатність витримувати довготривалі бої. Підтримка може змінюватися в залежності від внутрішньополітичної ситуації, економічного становища та результатів попередніх битв.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 2,
                    Name = "Підтримка народу",
                    Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 3,
                    Name = "Стан армії",
                    Description = "Стан армії — цей параметр визначає бойову готовність та моральний стан військових сил вашої нації. Він включає в себе декілька факторів, таких як рівень підготовки солдатів, наявність зброї та техніки, а також мораль і дисципліну в рядах армії. Високий рівень стану армії свідчить про добре оснащені та мотивовані війська, здатні ефективно вести бойові дії. Низький рівень, навпаки, може призвести до втрат у битвах, зниження моралі та навіть до бунтів серед військових.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 4,
                    Name = "Скарбниця",
                    Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 5,
                    Name = "Кількість нашої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 6,
                    Name = "Кількість ворожої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 7,
                    Name = "Бойовий дух нашої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 8,
                    Name = "Бойовий дух ворожої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 9,
                    Name = "Організація нашої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 10,
                    Name = "Організація ворожої армії",
                    Description = "",
                    Value = 0
                },
            };
        }

        public List<Level> InitLevels(List<Parametrs> parametrs)
        {
            return new List<Level>
            {
                new Level()
                {
                    Id = 0,
                    Name = "Період Київської держави",
                    NameEng = "The period of the Kyiv state",
                    Description = "Олег став правителем Київської держави після того, як завоював Київ, вигнавши Аскольда і Діра, ймовірно, через внутрішні суперечки і нестабільність їхнього правління. Олег спочатку був регентом для малолітнього сина Аскольда, Ігоря, і взяв під контроль місто. Він встановив стабільну владу, зміцнивши союз з новгородцями та поширивши свою політичну і військову впливовість на території Русі.",
                    DescriptionEng = "Oleg became the ruler of the Kyivan state after conquering Kyiv, expelling Askold and Dir, probably due to internal disputes and the instability of their rule. Oleg was initially regent for Askold's young son, Igor, and took control of the city. He established stable power, strengthening the alliance with the Novgorodians and spreading his political and military influence on the territory of Rus.",
                    YearStart = 882,
                    CountriesOpen = new List<Country>()
                    {
                        new Country()
                        {
                            Id = 0,
                            Name = "Київська держава",
                            Description = "Київська держава — це середньовічне об'єднання східнослов'янських племен, яке існувало з кінця IX століття до середини XIII століття. Київ, столиця держави, став важливим політичним, економічним і культурним центром. Держава розвивалась під впливом варязьких правителів, таких як Рюрик і Олег, і здобула значну незалежність після укладення договорів з Візантією. Русь досягла розквіту за князювання Володимира Великого та Ярослава Мудрого, активно розвиваючи християнство, торгівлю і дипломатичні зв'язки.",
                            NameLeader = "Олег",
                            UrlLeader = "Oleg",
                            Parametrs = new List<Parametrs>
                            {
                                new Parametrs
                                {
                                    Id = 0,
                                    Name = parametrs[0].Name,
                                    Description = parametrs[0].Description,
                                    Value = 60
                                },
                                new Parametrs
                                {
                                    Id = 1,
                                    Name = parametrs[1].Name,
                                    Description = parametrs[1].Description,
                                    Value = 50
                                },
                                new Parametrs
                                {
                                    Id = 2,
                                    Name = parametrs[2].Name,
                                    Description = parametrs[2].Description,
                                    Value = 60
                                },
                                new Parametrs
                                {
                                    Id = 3,
                                    Name = parametrs[3].Name,
                                    Description = parametrs[3].Description,
                                    Value = 50
                                },
                                new Parametrs
                                {
                                    Id = 4,
                                    Name = parametrs[4].Name,
                                    Description = parametrs[4].Description,
                                    Value = 83
                                },
                                new Parametrs
                                {
                                    Id = 5,
                                    Name = parametrs[5].Name,
                                    Description = parametrs[5].Description,
                                    Value = 11000
                                },
                            },
                            Turns = new List<Turn>
                            {
                                new Turn()
                                {
                                    Id = 0,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Ти вже захопив Київ, зробив його серцем нової держави, але тепер тобі необхідно поширити свою владу далі на південь і захід. Плем'я древлян — ключ до зміцнення твоєї позиції. Вони володіють багатими землями, густими лісами та важливими торговими шляхами. Однак їхня незалежність і відмова сплачувати данину — це виклик твоїй владі, а також загроза стабільності новоствореного об'єднання.",
                                            TextEng = "You have already captured Kyiv, made it the heart of the new state, but now you need to extend your power further to the south and west. The Drevlian tribe is the key to strengthening your position. They have rich lands, dense forests and important trade routes. However, their independence and refusal to pay tribute is a challenge to your authority, as well as a threat to the stability of the newly formed association."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Древляни досі платили данину хозарам, але тепер ти маєш замінити хозарів. Це зміцнить економічну базу твоєї держави та покаже іншим племенам силу твоєї влади: «Не давайте хозарам, але мені давайте». Також, землі древлян розташовані на шляху з півночі на захід, це важливий перехід між Дніпром та західними землями. Якщо вони підкоряться тобі, ти зможеш використовувати ці землі для походів далі на захід і підкорення нових територій.",
                                            TextEng = "The Drevlians still paid tribute to the Khazars, but now you must replace the Khazars. This will strengthen the economic base of your state and show other tribes the strength of your power: \"Don't give to the Khazars, but give to me.\" Also, the lands of the Drevlians are located on the way from the north to the west, this is an important transition between the Dnieper and the western lands. If they submit to you, you can use these lands to march further west and conquer new territories."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Армія древлян не велика за чисельністю, але небезпечна завдяки своїм знанням місцевості та вмінню використовувати природні укріплення лісів. Їхнє ополчення налічує приблизно 3–5 тисяч воїнів, озброєних луками, сокирами та дротиками. Основу їхніх сил складають селяни-ополченці, які звикли боронити свої землі від сусідніх племен.",
                                            TextEng = "The Drevlian army is not large in number, but dangerous due to its knowledge of the area and the ability to use the natural fortifications of the forests. Their militia numbers approximately 3,000 to 5,000 warriors armed with bows, axes, and darts. The basis of their forces are militia peasants who are used to defending their lands from neighboring tribes."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Проте їхня слабкість — це відсутність єдиного командування та стратегічного мислення. Вони звикли діяти розосереджено, тому твоя дисциплінована дружина, підкріплена кіннотою та варязькою піхотою, здатна швидко розгромити їх у відкритій битві.",
                                            TextEng = "However, their weakness is the lack of unified command and strategic thinking. They are used to operating in a dispersed manner, so your disciplined wife, supported by cavalry and Varangian infantry, can quickly defeat them in an open battle."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка до походу",
                                        Description = "З Києва ти вже розіслав вістунів по всіх землях півночі, збираючи під свої знамена дружинників з Новгорода, Смоленська та інших міст. Твоя мета — підкорити древлян і змусити їх сплачувати данину Києву. Ти знаєш, що це плем’я відоме своєю войовничістю, але їхні укріплення — це лише ліси й болотяні перепони, а не кам’яні стіни. Тому перший крок — зібрати силу, яка зможе здолати їхній опір.",
                                        DescriptionEng = "From Kyiv, you have already sent messengers to all the lands of the north, gathering soldiers from Novgorod, Smolensk and other cities under your banner. Your goal is to conquer the Drevlians and force them to pay tribute to Kyiv. You know that this tribe is known for its wariness, but their fortifications are only forests and marshy barriers, not stone walls. Therefore, the first step is to gather a force that can overcome their resistance.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 1,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Великий княже Олегу!\nТи вже підготувався до походу на древлян, зібравши велику дружину, підготувавши флотилію на Дніпрі та залучивши союзників зі слов’янських племен. Твоє військо вирушає з Києва у напрямку Іскоростеня, щоб примусити древлян визнати твою владу та сплачувати данину Києву замість хозарів.",
                                            TextEng = "Great Prince Oleg!\nYou have already prepared for the campaign against the Drevlians, gathering a large army, preparing a flotilla on the Dnieper and attracting allies from the Slavic tribes. Your army is leaving Kyiv in the direction of Iskorosten to force the Drevlians to recognize your authority and pay tribute to Kyiv instead of the Khazars."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Ти вирушив на початку весни 883 року, коли річки вже розлилися після зими, але шляхи ще не заросли густим лісом. Твоя флотилія пливе вниз по Дніпру, а за нею крокує піхота та кіннота через густі ліси Полісся. Древляни спробували створити засідки, використовуючи болотяні місця та природні перепони, але твоя розвідка вчасно виявила ці пастки. Ти обрав обхідний шлях, уникнувши втрат і заощадивши час.",
                                            TextEng = "You set out in the early spring of 883, when the rivers had already overflowed after the winter, but the paths were not yet overgrown with dense forest. Your flotilla sails down the Dnieper, followed by infantry and cavalry through the dense forests of Polissia. The Drevlians tried to set up ambushes, using swampy areas and natural obstacles, but your reconnaissance detected these traps in time. You chose a detour, avoiding losses and saving time."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти стоїш перед вирішальним моментом походу на древлян — облогою Іскоростеня. Саме зараз твоя здатність командувати військом і приймати швидкі рішення буде випробувана. Це місто — останній оплот древлянського опору, і його падіння засвідчить твою непохитну владу. Щоб успішно взяти місто, тобі слід врахувати декілька ключових моментів і продумати тактику атаки.",
                                            TextEng = "You are facing the decisive moment of the campaign against the Drevlyans - the siege of Iskorosten. Right now, your ability to command troops and make quick decisions will be tested. This city is the last stronghold of the Drevlyan resistance, and its fall will testify to your steadfast power. In order to successfully take the city, you should consider several key points and think through the tactics of the attack."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Облога Іскоростення",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 5000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 30
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Oleg"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 2,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Великий княже Олегу!\r\n\r\nТвоя перемога над древлянами завершилася блискучим тріумфом. Іскоростень, головне місто древлян, впало перед твоєю військовою майстерністю і стратегією, а древляни визнали твою владу та схилили голову перед Києвом. Ця перемога стала ще однією славною сторінкою у твоїй кар’єрі володаря та завойовника.",
                                            TextEng = "Great Prince Oleg!\r\n\r\nYour victory over the Drevlians ended in a brilliant triumph. Iskorosten, the main city of the Drevlians, fell before your military skill and strategy, and the Drevlians recognized your authority and bowed their heads to Kiev. This victory became another glorious page in your career as a ruler and conqueror."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Ти продемонстрував мудрість великого правителя, не знищивши місто дощенту, але наказавши залишити мешканців живими. Древляни присягнули на вірність тобі, зобов’язалися щорічно сплачувати данину Києву медом, хутром та іншими цінними товарами. Цей жест не лише підкорив їхню волю, але й забезпечив стабільність у регіоні.\r\n\r\nТвоя перемога над древлянами підняла твій авторитет серед інших племен, які тепер бачать тебе як володаря всієї Русі, здатного здолати будь-якого ворога. Здобич і данина збагатили скарбницю Києва, а нові воїни поповнили ряди твоєї дружини.",
                                            TextEng = "You showed the wisdom of a great ruler, not destroying the city to the ground, but ordering to leave the inhabitants alive. The people of Drevlya swore allegiance to you, pledged to pay tribute to Kyiv annually with honey, fur and other valuable goods. This gesture not only conquered their will, but also ensured stability in the region.\r\n\r\nYour victory over the Drevlians raised your authority among other tribes, who now see you as the ruler of all of Russia, capable of defeating any enemy. Booty and tribute enriched the treasury of Kyiv, and new soldiers joined the ranks of your wife."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Перемога над древлянами принесла не лише територіальні та економічні вигоди, але й зміцнила військову міць Київської Русі. Підкорення цього племені дозволило тобі, великий княже Олегу, залучити місцевих ополченців і воїнів до складу своєї дружини. Багато древлянських чоловіків, які ще недавно тримали зброю проти тебе, тепер стали частиною твоїх військових сил. Це рішення було мудрим стратегічним кроком, оскільки ти не лише посилив армію, але й зменшив потенційну загрозу з боку повстань серед підкореного населення.",
                                            TextEng = "The victory over the Drevlians brought not only territorial and economic benefits, but also strengthened the military power of Kyivan Rus. The subjugation of this tribe allowed you, Grand Duke Oleg, to attract local militiamen and warriors to the composition of your wife. Many Drevlyan men who until recently took up arms against you have now become part of your military forces. This decision was a wise strategic move, as you not only strengthened the army, but also reduced the potential threat of rebellions among the conquered population."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Кінець 883",
                                        Description = "Ось і кінець 883 року, великий княже Олегу!\n\n Але неподаліік є ще одне плем'я котре є під впливом хозарів. Сіверяни, одне з потужних слов’янських племен, ще не визнали твоєї влади. Їхні землі розташовані на північному сході, вздовж приток Десни й Сейму, і мають стратегічне значення для зміцнення впливу Києва. Вони сплачують данину хозарам, і це неприйнятно для єдності Русі. Щоб підготуватися до походу проти них, ти маєш ретельно спланувати кожен крок.",
                                        DescriptionEng = "This is the end of the year 883, Grand Duke Oleg!\n\n But nearby there is another tribe that is under the influence of the Khazars. The Severians, one of the powerful Slavic tribes, have not yet recognized your authority. Their lands are located in the northeast, along the tributaries of the Desna and Seim rivers, and are of strategic importance for strengthening Kyiv's influence. They pay tribute to the Khazars, and this is unacceptable for the unity of Russia. To prepare for the campaign against them, you have to carefully plan every step.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 93
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 1500
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 3,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Олегу Віщий, наша сила і влада потребують постійного зміцнення, і для цього нам потрібно мобілізувати всі наявні ресурси для наступного походу проти сіверян. Цей похід — не просто завоювання нових земель, але й необхідність продемонструвати решті слов’янських племен, що Київська Русь є незаперечним лідером на цих теренах. Для цього потрібно не лише покладатися на дружину, а й залучити місцеві сили, створити потужну армію, яка здатна подолати будь-який опір.",
                                            TextEng = "Oleg Vishchy, our strength and power need constant strengthening, and for this we need to mobilize all available resources for the next campaign against the northerners. This campaign is not just the conquest of new lands, but also the need to demonstrate to the rest of the Slavic tribes that Kyivan Rus is the undisputed leader in these areas. For this, it is necessary not only to rely on the wife, but also to attract local forces, to create a powerful army capable of overcoming any resistance."
                                        }
                                    },
                                    Choises = new List<Choise>
                                    {
                                        new Choise()
                                        {
                                            Id = 0,
                                            Name = "Мобілізація",
                                            Elements = new List<ElementChoise>
                                            {
                                                new ElementChoise()
                                                {
                                                    Id = 0,
                                                    Name = "Мобілізувати населення",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 11000
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 1,
                                                            Name = "Підтримка народу",
                                                            Description = parametrs[2].Description,
                                                            Value = -10
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 2,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -150
                                                        },
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 1,
                                                    Name = "Не проводити мобілізацію"
                                                }
                                            }
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка",
                                        Description = "Олегу Віщий, твоя підготовка до походу завершена!\r\n\r\nТабори наповнені гомоном воїнів, які перевіряють зброю та спорядження. У кованих мечах блищить загартована сталь, стріли загострені й готові пронизати навіть найміцніший обладунок. Твої дружинники, досвідчені й загартовані в битвах, піднесені духом і готові до нових подвигів. Зібране ополчення з древлян і полян, хоча й менш досвідчене, та все ж сповнене рішучості підтримати свого князя. Коли настане світанок, твоя армія виступить у похід. Цей день стане початком нової сторінки в історії Київської Русі. Твоє військо, як непереможна хвиля, рушить уперед, аби зміцнити твою владу, об’єднати руські землі та принести Києву нові здобутки.",
                                        DescriptionEng = "Oleg Vishchy, your preparations for the campaign are complete!\r\n\r\nThe camps are filled with the noise of soldiers checking weapons and equipment. Forged swords gleam with hardened steel, arrows sharpened and ready to pierce even the strongest armor. Your soldiers, experienced and hardened in battles, are high in spirit and ready for new exploits. The assembled militia from the Drevlians and Polyans, although less experienced, is still determined to support their prince. When dawn comes, your army will march. This day will be the beginning of a new page in the history of Kyivan Rus. Your army, like an invincible wave, is moving forward to strengthen your power, unite the Russian lands and bring new gains to Kyiv.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 4,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Олегу Віщий, твій похід проти сіверян став проявом мудрості, сили й стратегічного мистецтва. Коли твоє військо залишило Київ, потужний потік зброєносців і ополченців рушив уздовж Дніпра, прямуючи до земель сіверян. У кожному кроці відчувалась мета — розширення влади й об’єднання слов’янських земель під твоїм правлінням.",
                                            TextEng = "Oleg Vischy, your campaign against the northerners was a manifestation of wisdom, strength and strategic art. When your army left Kyiv, a powerful stream of gunmen and militia moved along the Dnieper, heading for the lands of the northerners. In every step, the goal was felt - the expansion of power and the unification of the Slavic lands under your rule."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "На підступах до сіверянських укріплень відчувалася напруга. Місцеві племена зібралися, щоб захистити свою землю, але твоя армія була сильнішою. Перші зіткнення на околицях сіверянських поселень показали їхню рішучість, та твої дружинники, зміцнені попередніми перемогами, зламали цей спротив.",
                                            TextEng = "Tension was felt on the approaches to the northern fortifications. The local tribes gathered to defend their land, but your army was stronger. The first clashes on the outskirts of the northern settlements showed their determination, and your soldiers, strengthened by previous victories, broke this resistance."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Олегу Віщий, битва вже близько, і кожна деталь твоєї підготовки вплине на її результат. Ти стоїш перед вирішальним моментом, коли сила, мудрість і віра в перемогу об’єднаються в один могутній удар.\r\n\r\nТвоя армія готується до останнього кроку — облоги головного укріплення сіверян. Ти особисто перевіряєш все: від готовності лучників до стану облогових машин. Дерев’яні тарани стоять напоготові, їхнє дерево скрипить під натиском твоїх дружинників, які тренуються розбивати ворота. Металеві наконечники стріл блищать на сонці, готові розпочати нищівний обстріл. На світанку ти даєш сигнал. Облогові машини рухаються вперед, тарани розгойдуються під натиском дружинників, а в небі з’являється перший дощ із палаючих стріл. Битва починається, і ти, Олегу, стоїш на передовій, ведучи своїх людей до ще однієї славетної перемоги.",
                                            TextEng = "Oleg Vishchy, the battle is near, and every detail of your preparation will affect its outcome. You are facing a decisive moment, when strength, wisdom and faith in victory will unite in one powerful blow.\r\n\r\nYour army is preparing for the last step - the siege of the main stronghold of the northerners. You personally check everything: from the readiness of archers to the condition of siege engines. The wooden battering rams stand at the ready, their wood creaking under the onslaught of your squires, who are trained to break down gates. Metal arrowheads glisten in the sun, ready to launch a devastating barrage. At dawn you give the signal. The siege machines move forward, the battering rams swing under the onslaught of the soldiers, and the first rain of flaming arrows appears in the sky. The battle begins, and you, Oleg, stand on the front line, leading your men to another glorious victory."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Облога укріплень сіверян",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 5000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 30
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Oleg"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 5,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Олегу Віщий, твоє завоювання сіверян не стало лише перемогою меча — це був початок нової епохи єдності та могутності Русі.\r\n\r\nПісля тріумфу твої воїни увійшли до землі сіверян як господарі, але з мудрістю та далекоглядністю ти не прагнув знищити цих людей. Ти наказав зібрати їхніх старійшин, щоб укласти мир і домовитися про їхню нову роль у Русі. Сіверяни, вражені твоєю силою та стратегією, прийняли твої умови, визнавши владу Києва.",
                                            TextEng = "Oleg Vishchy, your conquest of the northerners was not only a victory of the sword - it was the beginning of a new era of unity and power of Russia.\r\n\r\nAfter the triumph, your warriors entered the land of the Northmen as masters, but with wisdom and foresight you did not seek to destroy these people. You ordered to gather their elders to make peace and agree on their new role in Russia. The northerners, impressed by your strength and strategy, accepted your terms, recognizing the authority of Kyiv."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Землі сіверян тепер стали частиною твоєї держави. Ти встановив чіткі правила данини, яка тепер ішла не до хозарів, а до Києва. Це не лише підривало вплив ворога, але й посилювало твій авторитет серед інших племен. Відтепер твої ресурси зросли, скарбниця наповнювалася, а землі стали важливим щитом між Київською державою та кочівниками.\r\n\r\nНе зупиняючись на цьому, ти побачив у сіверянах нову силу для свого війська. Ти залучив їхніх найкращих воїнів до дружини, підготувавши їх до майбутніх походів. Їхні руки, які ще недавно тримали зброю проти тебе, тепер тримали мечі за тебе. Завдяки цьому твоє військо стало ще чисельнішим і сильнішим.",
                                            TextEng = "The lands of the northerners have now become part of your state. You established clear rules for the tribute, which now went not to the Khazars, but to Kyiv. This not only undermined the influence of the enemy, but also strengthened your authority among other tribes. From now on, your resources increased, the treasury was filled, and the lands became an important shield between the Kyivan state and the nomads.\r\n\r\nNot stopping at this, you saw in the northerners a new strength for your army. You brought their best warriors to wife, preparing them for the coming campaigns. Their hands, which not long ago held weapons against you, now held swords for you. Thanks to this, your army became even more numerous and stronger."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Однак, Олегу, це була не лише перемога зброї, але й перемога духу. Ти показав усій Русі, що під твоєю владою різні племена можуть об’єднатися в одну могутню державу, яка диктує свої умови ворогам. Сіверяни, відчувши твою силу й справедливість, стали частиною цього великого об’єднання.\r\n\r\nІ ось ти стоїш, дивлячись на свої нові володіння, впевнений, що ця перемога стане лише початком для ще більших звершень. Бо Київ тепер — не лише центр влади, а й серце землі, що прагне до єдності й слави.",
                                            TextEng = "However, Oleg, it was not only a victory of weapons, but also a victory of the spirit. You showed all of Russia that under your rule different tribes can unite into one powerful state that dictates its terms to the enemies. Northerners, feeling your strength and justice, became part of this great union.\r\n\r\nAnd here you stand, looking at your new possessions, confident that this victory will be only the beginning of even greater achievements. Because Kyiv is now not only the center of power, but also the heart of the earth, striving for unity and glory."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Олегу Віщий, наша сила і влада потребують постійного зміцнення, і для цього нам потрібно мобілізувати всі наявні ресурси для наступного походу проти сіверян. Цей похід — не просто завоювання нових земель, але й необхідність продемонструвати решті слов’янських племен, що Київська Русь є незаперечним лідером на цих теренах. Для цього потрібно не лише покладатися на дружину, а й залучити місцеві сили, створити потужну армію, яка здатна подолати будь-який опір.",
                                            TextEng = "Oleg Vishchy, our strength and power need constant strengthening, and for this we need to mobilize all available resources for the next campaign against the northerners. This campaign is not just the conquest of new lands, but also the need to demonstrate to the rest of the Slavic tribes that Kyivan Rus is the undisputed leader in these areas. For this, it is necessary not only to rely on the wife, but also to attract local forces, to create a powerful army capable of overcoming any resistance."
                                        }
                                    },
                                    Choises = new List<Choise>
                                    {
                                        new Choise()
                                        {
                                            Id = 0,
                                            Name = "Мобілізація",
                                            Elements = new List<ElementChoise>
                                            {
                                                new ElementChoise()
                                                {
                                                    Id = 0,
                                                    Name = "Мобілізувати населення",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 11000
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 1,
                                                            Name = "Підтримка народу",
                                                            Description = parametrs[2].Description,
                                                            Value = -10
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 2,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -150
                                                        },
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 1,
                                                    Name = "Не проводити мобілізацію"
                                                }
                                            }
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Кінець 884",
                                        Description = "Ось і кінець 884 року, великий княже Олегу!\r\nТвої знамена вже майоріють над землями сіверян, а їхня данина тепер наповнює скарбницю Києва. Але на південному заході, вздовж приток Дністра й Прута, знаходиться плем’я тиверців. Їхні укріплені поселення й густі ліси створюють природний захист, але вони не можуть сховатися від твоєї далекоглядності.\r\nТиверці, як і сіверяни, перебувають під впливом Хозарського каганату, сплачуючи їм данину. Це ставить під загрозу твоє бачення єдності всіх слов’янських племен під Київською короною. Їхні землі — ключ до повного контролю над південними торговими шляхами, що ведуть до Чорного моря. Без цього Київ не зможе стати центром усієї Русі.\r\nЗимові дні вже принесли спокій у табори твоїх воїнів, але ти, Олегу, не знаєш відпочинку. Ти міркуєш, як краще провести новий похід. Важливо, щоб твої сили були підготовлені до гірських стежок і річкових переправ, які захищають ці землі. Ти розумієш, що підкорення тиверців не лише посилить Київ, але й підірве залишки хозарського впливу. Пора підняти прапор над цими землями, княже. Твоє ім’я має стати символом єдності й могутності, що веде Русь до слави!",
                                        DescriptionEng = "This is the end of the year 884, Grand Duke Oleg!\r\nYour banners already fly over the lands of the northerners, and their tribute now fills the treasury of Kyiv. But in the southwest, along the tributaries of the Dniester and Prut rivers, there is a tribe of Tivers. Their fortified settlements and dense forests provide natural protection, but they cannot hide from your foresight.\r\nThe Tiberians, like the Northerners, are under the influence of the Khazar Khaganate, paying tribute to them. This endangers your vision of the unity of all Slavic tribes under the Kyivan crown. Their lands are the key to complete control of the southern trade routes leading to the Black Sea. Without this, Kyiv will not be able to become the center of all of Rus.\r\nThe winter days have already brought peace to the camps of your soldiers, but you, Oleg, know no rest. You think about how best to spend a new campaign. It is important that your forces are prepared for the mountain trails and river crossings that protect these lands. You understand that conquering the Tiberians will not only strengthen Kyiv, but also undermine the remnants of Khazar influence. It's time to raise the flag over these lands, prince. Your name should become a symbol of unity and power, leading Rus' to glory!",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 103
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 1500
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 6,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Похід проти тиверців, великий княже Олегу, став наступним кроком у твоєму шляху до об’єднання всіх слов’янських племен під владою Києва. Ця кампанія була не лише воєнною, але й стратегічною та символічною — вона затверджувала твій авторитет як великого правителя Русі.",
                                            TextEng = "The campaign against the Tivertians, Grand Prince Oleg, was the next step on your path to uniting all Slavic tribes under the rule of Kyiv. This campaign was not only military, but also strategic and symbolic - it affirmed your authority as the great ruler of Rus."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Тиверці, захищені річками та гірськими стежками, покладалися на свої природні укріплення й досвід у партизанській війні. Вони були гордим народом, але залежність від Хозарського каганату зробила їх вразливими до зовнішнього впливу. Ти вирішив діяти швидко та рішуче, щоби захопити їхні землі й зламати хозарський контроль.\r\n\r\nТвій похід розпочався ранньою весною. Об’єднавши дружинників, ти провів їх через ліси й рівнини, використовуючи знання місцевості, зібрані твоїми розвідниками. Річки, які раніше служили тиверцям оборонним бар’єром, стали шляхами для твоїх легких човнів, що рухалися вгору по течії, доставляючи війська до самих укріплених поселень.",
                                            TextEng = "Protected by rivers and mountain passes, the Tiverts relied on their natural fortifications and their experience in guerrilla warfare. They were a proud people, but their dependence on the Khazar Khaganate made them vulnerable to outside influence. You decided to act quickly and decisively to seize their lands and break Khazar control.\r\n\r\nYour campaign began in early spring. Uniting your warriors, you led them through forests and plains, using the knowledge of the terrain gathered by your scouts. The rivers that had previously served as a defensive barrier for the Tiverts became the paths for your light boats, moving upstream, delivering troops to the most fortified settlements."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Звістка надійшла перед світанком, великий княже Олегу. Розвідники, які ризикували життям, пробираючись крізь болота й густі ліси, донесли, що головні сили тиверців зосереджені на західному березі Прута. Їхній табір стоїть серед природного укріплення — річка захищає з одного боку, густі хащі — з іншого. Вороги впевнені, що ця місцевість робить їх неприступними. Вони помиляються.",
                                            TextEng = "The news came before dawn, Grand Duke Oleg. The scouts, who risked their lives, making their way through the swamps and dense forests, reported that the main forces of the Tiverians were concentrated on the western bank of the Prut. Their camp is located among natural fortifications - the river protects on one side, dense thickets - on the other. The enemies are sure that this terrain makes them impregnable. They are mistaken."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Ти уважно слухаєш кожне слово розвідників. Їхні описи деталей — розташування сторожових постів, чисельність воїнів, наявність бродів через річку — малюють чітку картину. Тиверців близько п’яти тисяч. Вони під проводом місцевих ватажків, і це їхній недолік: бракує єдиного лідера, який міг би організувати справжню оборону.\r\n\r\nТи вирішуєш діяти негайно. Накази лунають швидко й чітко: дружина починає готуватися до маршу. Ти обираєш найкращих лучників для першого удару, який має спричинити паніку серед ворога. Піхота отримує наказ пробиватися через передній вал оборони, а кіннота займе обхідний маршрут через ліс, щоб замкнути ворога в кільце.",
                                            TextEng = "You listen carefully to every word the scouts say. Their descriptions of the details—the location of the guard posts, the number of soldiers, the presence of fords across the river—paint a clear picture. There are about five thousand Tivertians. They are led by local leaders, and this is their disadvantage: they lack a single leader who could organize a real defense.\r\n\r\nYou decide to act immediately. The orders come quickly and clearly: the squad begins to prepare for the march. You choose the best archers for the first strike, which is to cause panic among the enemy. The infantry is ordered to break through the front defense wall, while the cavalry will take a roundabout route through the forest to encircle the enemy."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Твоя присутність серед воїнів надихає. Вони бачать у тобі не лише князя, а й полководця, що йде з ними в бій. Ти обходиш лави, перевіряєш зброю, вислуховуєш останні поради старійшин дружини. Лучники поправляють тятиви, піхотинці перевіряють гостроту мечів і надійність щитів, кіннотники готують коней до швидкого маневру.\r\n\r\nТвій план чіткий, як стріла, що летить до цілі. Ти знаєш, що ця перемога не лише зламає опір тиверців, але й остаточно підкреслить силу Києва. Ти дивишся на горизонт, де ще ніч тримає небо, і знаєш: світанок принесе не лише новий день, а й нову славу для Русі.",
                                            TextEng = "Your presence among the warriors is inspiring. They see you not only as a prince, but also as a commander who is going into battle with them. You go around the ranks, inspect your weapons, and listen to the latest advice from the elders of the squad. Archers adjust their bowstrings, infantrymen check the sharpness of their swords and the reliability of their shields, and cavalrymen prepare their horses for a quick maneuver.\r\n\r\nYour plan is as clear as an arrow flying to its target. You know that this victory will not only break the resistance of the Tiverians, but will also finally emphasize the power of Kiev. You look at the horizon, where night still holds the sky, and you know: dawn will bring not only a new day, but also new glory for Rus."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Облога укріплень сіверян",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 5000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 30
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Oleg"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 7,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Землі тиверців, багаті на родючі поля та зручні торгові шляхи, стали важливим додатком до Київської держави. Ти розпорядився встановити контроль над головними річковими шляхами, які пролягали через їхні території, забезпечуючи зв’язок між північчю та півднем. Це дозволило зміцнити торгівлю із землями на узбережжі Чорного моря й послабити залежність від хозарських шляхів.\r\n\r\nТиверці, визнавши твою владу, погодилися сплачувати данину Києву. Замість хозарів, їхні багатства тепер ішли на зміцнення твоєї держави. Але ти діяв не тільки силою: ти знав, що союз із тиверцями буде більш надійним, якщо вони відчують користь від твого правління. Ти дозволив їхнім старійшинам зберігати частину самоуправління, але під твоїм чітким наглядом.",
                                            TextEng = "The lands of the Tiverts, rich in fertile fields and convenient trade routes, became an important addition to the Kievan state. You ordered to establish control over the main river routes that ran through their territories, providing a connection between the north and the south. This allowed to strengthen trade with the lands on the Black Sea coast and to weaken dependence on the Khazar routes.\r\n\r\nThe Tiverts, recognizing your authority, agreed to pay tribute to Kiev. Instead of the Khazars, their wealth now went to strengthen your state. But you acted not only by force: you knew that the alliance with the Tiverts would be more reliable if they felt the benefits of your rule. You allowed their elders to retain some self-government, but under your strict supervision."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Щоб гарантувати лояльність, ти залишив частину своєї дружини для охорони ключових місць і водночас запропонував тиверським воїнам увійти до твоїх лав. Ті, хто ще вчора стояв проти тебе, тепер воювали на твоєму боці, готові брати участь у нових походах. Їхній досвід у партизанській війні став корисним у майбутніх кампаніях.\r\n\r\nЦя перемога мала значення не лише для Києва, а й для твоєї репутації серед інших слов’янських племен. Вони бачили, що під твоєю владою зникають внутрішні конфлікти й посилюється зовнішній захист. Київська Русь дедалі більше ставала не просто зібранням племен, а потужною державою, яка прагне до об’єднання всіх слов’ян.",
                                            TextEng = "To ensure loyalty, you left part of your squad to guard key places and at the same time invited the Tiver warriors to join your ranks. Those who had been against you yesterday were now fighting on your side, ready to take part in new campaigns. Their experience in guerrilla warfare became useful in future campaigns.\r\n\r\nThis victory was important not only for Kiev, but also for your reputation among other Slavic tribes. They saw that under your rule internal conflicts were disappearing and external protection was strengthening. Kievan Rus was increasingly becoming not just a gathering of tribes, but a powerful state striving to unite all Slavs."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Кінець 885 року",
                                        Description = "Тепер, коли тиверці визнали твою владу, твій погляд міг звернутися до нових цілей. Попереду лежали інші племена, а також могутні сусіди, які ще не відчули на собі силу твоєї держави. Цей успіх був лише черговим кроком на шляху до створення великої і єдиної Русі.",
                                        DescriptionEng = "Now that the Tyvets recognized your authority, your gaze could turn to new goals. Other tribes lay ahead, as well as powerful neighbors who had not yet felt the power of your state. This success was just another step on the path to creating a great and united Rus.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 1500
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 8,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Ти, великий княже Олегу, вирішив кинути виклик хозарському пануванню над радимичами. Ця підготовка була не лише військовою кампанією, але й стратегічним кроком, щоб закріпити владу Києва як центру сили на Русі.\r\n\r\nТвої радники доповіли, що радимичі досі платять данину хозарам, вбачаючи в них непереможну силу. Але ти, зібравши свою дружину, був переконаний: це питання не тільки честі, а й права. Землі радимичів розташовані у самому серці торговельних шляхів, і їхній контроль означав би значне підсилення твоєї влади.",
                                            TextEng = "You, Grand Prince Oleg, decided to challenge the Khazar rule over the Radimichs. This preparation was not only a military campaign, but also a strategic step to consolidate the power of Kiev as the center of power in Rus.\r\n\r\nYour advisors reported that the Radimichs still pay tribute to the Khazars, seeing in them an invincible force. But you, having gathered your squad, were convinced: this is not only a matter of honor, but also of right. The lands of the Radimichs are located in the very heart of trade routes, and their control would mean a significant strengthening of your power."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "До цієї кампанії ти підійшов ґрунтовно. Зима 884 року стала часом розвідки. Твої люди вирушили на північний схід, збираючи інформацію про місця зібрання радимичів, чисельність їхніх воїнів і оборонні споруди. Повернувшись із подробицями, вони підтвердили: радимичі мають силу, але їхня організація поступається твоїй армії.\r\n\r\nТи також звернувся до племен, які вже були під твоєю владою. Сіверяни, що стали вірними після минулої кампанії, надали додаткові загони, а також постачання для походу. З їхніх рядів було обрано провідників, які добре знали місцевість, що мала стати ареною бойових дій.",
                                            TextEng = "You approached this campaign thoroughly. The winter of 884 was a time of reconnaissance. Your men set out to the northeast, gathering information about the gathering places of the Radimichi, the number of their warriors, and the defensive structures. Returning with details, they confirmed: the Radimichi are strong, but their organization is inferior to your army.\r\n\r\nYou also turned to the tribes that were already under your rule. The northerners, who had become loyal after the previous campaign, provided additional detachments, as well as supplies for the campaign. Leaders were chosen from their ranks who knew well the terrain that was to become the arena of hostilities."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Перед початком походу ти провів раду з дружиною. Там обговорювали не лише військову стратегію, але й дипломатичні кроки після перемоги. Твій план був простий, але вражаючий: розбити радимичів у відкритому бою, але не знищувати їх повністю. Їхнє підкорення мало бути не лише військовим, а й символічним кроком до об’єднання Русі.\r\n\r\nКоли лід у річках почав танути, ти відчув, що час настав. Дружина зібралася на київських пагорбах, готова до великого походу. Воїни співали пісень, налаштовуючи себе на перемогу. Ти, великий княже, з мечем у руках піднявся на пагорб, дивлячись на тих, хто вирушить із тобою в цю доленосну подорож.",
                                            TextEng = "Before the campaign, you held a council with your wife. They discussed not only military strategy, but also diplomatic steps after the victory. Your plan was simple but impressive: to defeat the Radimichi in open battle, but not to destroy them completely. Their subjugation was to be not only military, but also a symbolic step towards the unification of Rus.\r\n\r\nWhen the ice in the rivers began to melt, you felt that the time had come. Your wife gathered on the Kiev hills, ready for a great campaign. The warriors sang songs, setting themselves up for victory. You, the great prince, climbed the hill with a sword in your hands, looking at those who would go with you on this fateful journey."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка до бою",
                                        Description = "Ти, великий княже, на чолі дружини наблизився до поселення на берегах річки Сож, де радимичі зібралися, сподіваючись зупинити твій похід. Звістка про те, що вони облаштовують укріплення, прийшла з розвідки, і ти негайно віддав наказ готуватися до битви.",
                                        DescriptionEng = "You, the Grand Duke, at the head of your army approached the settlement on the banks of the Sozh River, where the Radimichi had gathered, hoping to stop your march. The news that they were equipping fortifications came from reconnaissance, and you immediately gave the order to prepare for battle.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 9,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Табір твоєї армії розташувався на пагорбі неподалік поселення. Це місце дозволяло спостерігати за рухами ворога та оцінювати їхні сили. У ніч перед боєм ти провів раду з воєводами. Були обговорені всі аспекти битви: можливі маневри ворога, використання місцевості для засідок, а також стратегія прориву оборонного рубежу радимичів.\r\n\r\nНа світанку твоя армія почала готуватися. Дружинники перевіряли свої мечі й списи, підганяли обладунки, напинали тятиви на луках. Ти особисто обійшов війська, підбадьорюючи своїх воїнів, які відчували твою рішучість і силу.",
                                            TextEng = "Your army camp was located on a hill near the settlement. This place allowed you to observe the enemy's movements and assess their strength. The night before the battle, you held a council with the voivodes. All aspects of the battle were discussed: possible enemy maneuvers, the use of the terrain for ambushes, as well as the strategy for breaking through the Radimichi defensive line.\r\n\r\nAt dawn, your army began to prepare. The cadets checked their swords and spears, adjusted their armor, and strung their bowstrings. You personally went around the troops, encouraging your soldiers, who felt your determination and strength."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Перед початком бою ти виступив перед військом. Твоя промова була короткою, але потужною. Ти нагадав воїнам, що вони захищають не лише Київську державу, а й честь Русі, об'єднуючи слов’янські землі під єдиним прапором. \"Хозари більше не будуть диктувати нашим братам, хто має бути їхнім господарем!\" — ці слова збурили дух дружинників, і вони були готові до боротьби. Коли сонце піднялося над горизонтом, твоє військо виступило.",
                                            TextEng = "Before the battle began, you addressed the army. Your speech was short but powerful. You reminded the soldiers that they were defending not only the Kievan state, but also the honor of Rus, uniting the Slavic lands under a single banner. \"The Khazars will no longer dictate to our brothers who should be their master!\" - these words stirred the spirit of the Druzhny warriors, and they were ready to fight. When the sun rose above the horizon, your army advanced."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Бій в Сожі",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 3000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 30
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Oleg"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 10,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після перемоги над радимичами, великий княже, настав час закріпити успіх і встановити новий порядок. Битва продемонструвала силу Києва та твою майстерність як воєначальника, але цього було недостатньо. Перемога мала бути не лише військовою, а й політичною.",
                                            TextEng = "After the victory over the Radimichs, Grand Duke, it was time to consolidate the success and establish a new order. The battle demonstrated the strength of Kyiv and your skill as a military leader, but this was not enough. The victory had to be not only military, but also political."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Старійшини радимичів, побачивши поразку свого війська, зрозуміли, що Київ є тією силою, яка змінить їхню долю. Вони зібралися на перемовини, і ти прийняв їх у своєму таборі. Говорили вони про збереження своїх традицій і звичаїв, але ти наполіг: вони мають припинити сплачувати данину хозарам і почати визнавати владу Києва. Це був не лише акт підкорення, а й символ звільнення від іноземного впливу.\r\n\r\nТи встановив новий порядок: радимичі мали платити данину Києву, але значно меншу, ніж та, яку вимагали хозари. Це стало першим кроком до зміцнення їхньої лояльності. Щоб закріпити новий союз, ти залишив свої гарнізони в ключових поселеннях і взяв із собою молодих радимичів у свою дружину, навчаючи їх київському військовому мистецтву.",
                                            TextEng = "The elders of the Radimichi, seeing the defeat of their army, realized that Kyiv was the force that would change their fate. They gathered for negotiations, and you received them in your camp. They talked about preserving their traditions and customs, but you insisted: they must stop paying tribute to the Khazars and begin to recognize the authority of Kyiv. This was not only an act of submission, but also a symbol of liberation from foreign influence.\r\n\r\nYou established a new order: the Radimichi were to pay tribute to Kyiv, but much less than the one demanded by the Khazars. This was the first step towards strengthening their loyalty. To consolidate the new alliance, you left your garrisons in key settlements and took young Radimichi with you into your squad, teaching them the Kyivan military art."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "886",
                                        Description = "Перемога над радимичами мала велике значення, великий княже. Проте вона була лише початком великої роботи, яка чекала тебе, щоб закріпити свій тріумф і зміцнити нові здобутки. Після битви, коли шум мечів і криків вщух, настав час діяти мудро і стратегічно.\r\n\r\nТи прийняв радимичівських старійшин у своєму таборі. Вони стояли перед тобою, ще похмурі після поразки, але вже готові слухати. Їхня данина хозарам була тягарем для їхнього народу, і ти наголосив, що Київ прийшов не як загарбник, а як визволитель. Цей аргумент, підкріплений твоєю могутністю, швидко вплинув на їхню волю. Вони визнали твою владу й погодилися платити данину Києву.",
                                        DescriptionEng = "The victory over the Radimichi was of great importance, great prince. However, it was only the beginning of the great work that awaited you to consolidate your triumph and consolidate new achievements. After the battle, when the noise of swords and shouts subsided, it was time to act wisely and strategically.\r\n\r\nYou received the Radimichi elders in your camp. They stood before you, still gloomy after their defeat, but already ready to listen. Their tribute to the Khazars was a burden for their people, and you emphasized that Kyiv had come not as an invader, but as a liberator. This argument, reinforced by your power, quickly influenced their will. They recognized your authority and agreed to pay tribute to Kyiv.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 1500
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 10,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після цього ти вирішив укріпити контроль над їхньою землею. Твої люди розмістили гарнізони в ключових містах радимичів, зокрема біля переправ і торгових шляхів, щоб забезпечити стабільність. Це також стало знаком того, що Київ тепер бере на себе відповідальність за захист цих земель від майбутніх загроз.\r\n\r\nТи не лише захищав нові території, але й дбав про їхнє інтегрування до своєї держави. Молодь із радимичів було залучено до твоєї дружини, щоб вони могли навчитися київської військової дисципліни та стати майбутніми провідниками своєї землі під твоїм знаменом.",
                                            TextEng = "After that, you decided to consolidate your control over their land. Your men stationed garrisons in key Radimichi cities, particularly near crossings and trade routes, to ensure stability. This also became a sign that Kyiv now took responsibility for protecting these lands from future threats.\r\n\r\nYou not only defended the new territories, but also ensured their integration into your state. Young Radimichi were recruited into your squad so that they could learn Kyivan military discipline and become future leaders of their land under your banner."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Проте ти не зупинився лише на військових і адміністративних діях. Торгові шляхи, які проходили через землі радимичів, тепер перебували під твоїм контролем. Ти наказав розвивати їх, щоб забезпечити постійний потік товарів і данини до Києва.\r\n\r\nЦя перемога була не лише символічною. Вона продемонструвала хозарам, що їхній вплив слабшає, і ти готовий відвоювати кожен клаптик землі, який вони раніше контролювали. Інші слов'янські племена почали розуміти, що Київ стає новим центром сили, до якого вони також можуть приєднатися.",
                                            TextEng = "However, you did not stop only at military and administrative actions. The trade routes that passed through the lands of the Radimichi were now under your control. You ordered them to be developed to ensure a constant flow of goods and tribute to Kiev.\r\n\r\nThis victory was not only symbolic. It demonstrated to the Khazars that their influence was weakening, and that you were ready to win back every piece of land that they had previously controlled. Other Slavic tribes began to understand that Kiev was becoming a new center of power, to which they could also join."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "887",
                                        Description = "Ці події стали важливим кроком на шляху до великої мети — об'єднання Русі під твоїм правлінням. Твоя мудрість і сила, великий княже, ведуть тебе до того, щоб зробити Київ серцем великої держави, яка встоїть перед будь-якими ворогами.",
                                        DescriptionEng = "These events were an important step towards the great goal of uniting Russia under your rule. Your wisdom and strength, great prince, lead you to make Kyiv the heart of a great state that will stand against any enemies.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 3000
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 11,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Під вечір, коли сонце опускалося за обрій, в твоєму наметі панувала напружена тиша. Розвідники доповіли: печеніги готові до перемовин. Це були ті самі кочовики, чиї наскоки завдавали великих збитків сусідам. Їхня стрімка кіннота могла обернутися як проти Києва, так і на твою користь, Олегу. Але якою ціною?",
                                            TextEng = "In the evening, as the sun sank below the horizon, a tense silence reigned in your tent. The scouts reported: the Pechenegs were ready for negotiations. These were the same nomads whose raids had caused great damage to their neighbors. Their swift cavalry could turn against Kyiv as well as in your favor, Oleg. But at what cost?"
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Перед тобою постав вибір. Мир із ними міг забезпечити спокій на східних кордонах, давши змогу зосередити всю увагу на хозарах. Проте чи можна довіряти тим, хто поважає лише силу? Їхня згода на ненапад може стати тимчасовим тріумфом, але чи не стане вона пасткою в майбутньому?",
                                            TextEng = "You have a choice to make. Peace with them could bring peace to the eastern borders, allowing you to focus all your attention on the Khazars. But can you trust those who respect only strength? Their agreement to non-aggression may be a temporary triumph, but will it not become a trap in the future?"
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "З іншого боку, ти міг обрати інший шлях — не домовлятися, а діяти рішуче. Відкрита війна з печенігами показала б твою міць усім сусіднім племенам. Але чи варто було ризикувати, коли головна битва попереду, і твоїм справжнім ворогом залишається Хозарський каганат?",
                                            TextEng = "On the other hand, you could have chosen another path - not to negotiate, but to act decisively. An open war with the Pechenegs would have shown your power to all neighboring tribes. But was it worth the risk when the main battle was ahead, and your real enemy remained the Khazar Khaganate?"
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "А ще був третій варіант: домовленість із болгарами, які прагнуть послабити хозар. Їхній торговий інтерес збігався з твоїм бажанням зміцнити економічну базу Києва. Вони могли стати надійними союзниками, але чи буде достатньо їхньої підтримки, якщо печеніги раптом змінять позицію?",
                                            TextEng = "And there was a third option: an agreement with the Bulgarians, who sought to weaken the Khazars. Their commercial interest coincided with your desire to strengthen the economic base of Kiev. They could become reliable allies, but would their support be enough if the Pechenegs suddenly changed their position?"
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "У цей момент, великий княже, ти стояв перед вирішальним вибором. Важкі думки та холодний розрахунок супроводжували тебе, бо доля Києва залежала не лише від сили меча, а й від мудрості твоїх рішень.",
                                            TextEng = "At this moment, great prince, you were faced with a crucial choice. Heavy thoughts and cold calculation accompanied you, because the fate of Kyiv depended not only on the power of the sword, but also on the wisdom of your decisions."
                                        }
                                    },
                                    Choises = new List<Choise>()
                                    {
                                        new Choise()
                                        {
                                            Id = 0,
                                            Name = "Дипломатія",
                                            Elements = new List<ElementChoise>()
                                            {
                                                new ElementChoise()
                                                {
                                                    Id = 0,
                                                    Name = "Мир із печенігами",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 6500
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -300
                                                        }
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 1,
                                                    Name = "Домовленість із болгарами",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 12500
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -500
                                                        }
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 2,
                                                    Name = "Ні з ким не домовлятися",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        
                                                    }
                                                }
                                            }
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "888",
                                        Description = "Підготовка до перемовин завершувалася, і всі рішення, великокняже, тепер лежали на твоїх плечах. Посли печенігів, чи, можливо, болгари або інші союзники, вже чекали на твоє слово, вірячи у твою мудрість і силу. Ти стояв перед вибором, що міг визначити майбутнє не лише твого правління, а й самої Русі.\r\n\r\nЧоловіки у дружині готували свої обладунки, а радники шепотіли про важливість кожного слова на цих переговорах. Хтось радив обережність, аби не спровокувати нові конфлікти, інші ж закликали до рішучості, аби нав’язати умови, які б принесли найбільшу користь Києву.",
                                        DescriptionEng = "The preparations for the negotiations were being completed, and all decisions, Grand Duke, now lay on your shoulders. The ambassadors of the Pechenegs, or perhaps the Bulgarians or other allies, were already waiting for your word, believing in your wisdom and strength. You were faced with a choice that could determine the future not only of your reign, but also of Rus' itself.\r\n\r\nThe men in the squad prepared their armor, and the advisors whispered about the importance of every word in these negotiations. Some advised caution so as not to provoke new conflicts, while others called for decisiveness in order to impose conditions that would bring the greatest benefit to Kiev.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 20
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 12,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Минули роки, великий княже Олегу, і Київська держава продовжувала зростати у своїй силі та впливі. З 889 по 906 рік ти не лише укріплював владу всередині країни, але й розширював її межі, готуючи ґрунт для великих звершень.",
                                            TextEng = "Years passed, Grand Prince Oleg, and the Kyivan state continued to grow in strength and influence. From 889 to 906, you not only strengthened your power within the country, but also expanded its borders, preparing the ground for great achievements."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Після встановлення союзів із печенігами та болгарами ти скерував свою увагу на внутрішню стабільність. У ці роки Київ об’єднував навколишні племена під одним знаменом, створюючи основу для єдиної держави. Землі деревлян, сіверян і тиверців поступово інтегрувалися в Київську Русь, забезпечуючи військову підтримку та економічну базу.\r\n\r\nТи не залишив поза увагою і хозар. Війна на східних рубежах тривала, але щоразу, коли їхні загони наближалися до твоїх земель, їх відкидали назад, немов хвилі об скелі. Ти навчив своїх людей захищати кордони й не дозволяв ворогу закріплюватися на підконтрольних землях.",
                                            TextEng = "After establishing alliances with the Pechenegs and Bulgarians, you turned your attention to internal stability. During these years, Kyiv united the surrounding tribes under one banner, creating the basis for a single state. The lands of the Drevlyans, Severians, and Tiverts gradually integrated into Kyivan Rus, providing military support and an economic base.\r\n\r\nYou did not ignore the Khazars. The war on the eastern borders continued, but every time their detachments approached your lands, they were thrown back like waves against a rock. You taught your people to defend the borders and did not allow the enemy to gain a foothold in the lands under your control."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Водночас, Олегу, ти розумів, що сила держави полягає не лише в мечі. Торгівля Києва процвітала, і шляхи «з варягів у греки» стали безпечними. Твої купці вільно плавали Дніпром, обмінюючи мед, хутро й віск на заморські товари. Болгари стали надійними партнерами, а печеніги більше не ризикували порушувати укладені угоди.",
                                            TextEng = "At the same time, Oleg, you understood that the power of the state lies not only in the sword. Kyiv's trade flourished, and the routes \"from the Varangians to the Greeks\" became safe. Your merchants sailed freely on the Dnieper, exchanging honey, furs, and wax for overseas goods. The Bulgarians became reliable partners, and the Pechenegs no longer risked violating the agreements they had made."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "907",
                                        Description = "Але ти завжди дивився далі. Візантія, найбагатша імперія свого часу, привертала твою увагу. Твої радники шепотіли про багатства Константинополя, про його незліченні скарби й незрівнянну торгівлю. У ці роки ти, великий княже, готувався. Ти знав, що прийде час, коли Київська Русь заявить про себе перед світом, і цей час наближався.\r\n\r\nІ ось тепер, на порозі 907 року, ти стоїш перед вирішальним кроком. Константинополь чекає. Його мури ще не знають, що означає гнів Києва, але скоро дізнаються. Це буде твоїм найславетнішим походом, який увійде в історію як доказ того, що Київська держава є силою, з якою рахуватиметься кожен.",
                                        DescriptionEng = "But you always looked further. Byzantium, the richest empire of its time, attracted your attention. Your advisors whispered about the riches of Constantinople, its countless treasures and unparalleled trade. During these years, you, the great prince, were preparing. You knew that the time would come when Kievan Rus would declare itself to the world, and that time was approaching.\r\n\r\nAnd now, on the threshold of 907, you stand before a decisive step. Constantinople awaits. Its walls do not yet know what the wrath of Kiev means, but they will soon find out. This will be your most glorious campaign, which will go down in history as proof that the Kievan state is a force to be reckoned with.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 13,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Великий княже Олегу, перед тобою завдання, що вимагає неабиякої підготовки. Похід на Константинополь — це не просто військовий крок, це виклик самому порядку речей у цих землях. Щоб успішно провести кампанію, ти маєш зібрати всі сили Київської держави та забезпечити їхню повну готовність до випробувань, які чекатимуть на шляху.",
                                            TextEng= "Grand Prince Oleg, you have a task before you that requires considerable preparation. The campaign against Constantinople is not just a military step, it is a challenge to the very order of things in these lands. To successfully conduct the campaign, you must gather all the forces of the Kievan state and ensure their full readiness for the trials that will await you on the way."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "У твоєму дворі вже кипить робота. Старійшини радять про те, як краще організувати флот і військо. Кожен меч, кожна стріла, кожен човен — це не просто зброя, а частина твоєї великої стратегії. Ти віддав накази зміцнити судна, обшивши їх деревом для захисту від стріл і вогню.\r\n\r\nВійськові майстри вдосконалюють озброєння. Щити варягів виблискують на сонці, мечі загострюють, а луки перевіряють на натяг. Твої дружинники тренуються щодня, відточуючи майстерність у стрільбі, фехтуванні та спільних побудовах.\r\n\r\nЗ усіх земель Київської держави ти зібрав найкращих воїнів. Слов'янські племена, варязькі найманці, навіть союзники з Болгарії й печенігів стоять під твоїм прапором. Їх об'єднує не лише сила меча, а й віра в твою мудрість.",
                                            TextEng = "Work is already in full swing in your yard. The elders advise on how to better organize the fleet and army. Every sword, every arrow, every boat is not just a weapon, but part of your grand strategy. You have given orders to strengthen the ships, sheathing them with wood to protect them from arrows and fire.\r\n\r\nMilitary masters are perfecting their weapons. The shields of the Varangians sparkle in the sun, swords are sharpened, and bows are checked for tension. Your warriors train daily, honing their skills in shooting, fencing, and joint construction.\r\n\r\nFrom all the lands of the Kievan state, you have gathered the best warriors. Slavic tribes, Varangian mercenaries, even allies from Bulgaria and the Pechenegs stand under your banner. They are united not only by the power of the sword, but also by faith in your wisdom."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти також дбаєш про провізію. По складах збирають запаси зерна, м'яса й меду, аби воїни не знали голоду в дорозі. Кожен човен облаштовують так, щоб він міг витримати тривалу подорож — як по річках, так і морем.\r\n\r\nРадники доповідають про стан доріг і шляхів. Шлях «з варягів у греки» перевірено, а дозорці слідкують, щоб жодна ворожа засада не порушила твого плану.\r\n\r\nНарешті, ти сам розробляєш стратегію. Головне — не лише дістатися до Константинополя, а й змусити імперію скоритися. Ти обмірковуєш кожен крок: як розташувати флот, як захистити людей від можливої засідки, як вразити ворога так, щоб він навіть не думав про спротив.",
                                            TextEng = "You also take care of provisions. Warehouses are stockpiled with grain, meat, and honey so that the soldiers do not know hunger on the way. Each boat is equipped so that it can withstand a long journey - both on rivers and at sea.\r\n\r\nAdvisors report on the condition of the roads and paths. The path \"from the Varangians to the Greeks\" has been checked, and sentries make sure that no enemy ambush disrupts your plan.\r\n\r\nFinally, you develop a strategy yourself. The main thing is not only to reach Constantinople, but also to force the empire to submit. You think over every step: how to position the fleet, how to protect people from a possible ambush, how to strike the enemy so that he does not even think about resistance."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Початок походу, великий княже Олегу, був сповнений рішучості та величі. Коли останні приготування завершилися, військо почало свій рух. Воїни збиралися на березі Дніпра, готові вирушити в дорогу. Човни стояли рівними рядами, їхні весла блищали на сонці. Кожен із них був завантажений провізією, зброєю та всім необхідним для тривалої подорожі.\r\n\r\nТи, великий княже, вийшов до дружини у бойових обладунках. Твій голос лунав упевнено й владно, коли ти закликав своїх воїнів бути непохитними. Ти говорив про велич Києва, про необхідність змусити Візантію визнати силу Русі та про ті багатства, які чекають на нас у Константинополі.",
                                            TextEng = "The beginning of the campaign, Grand Duke Oleg, was full of determination and grandeur. When the final preparations were completed, the army began its movement. The warriors gathered on the banks of the Dnieper, ready to set off. The boats stood in even rows, their oars gleaming in the sun. Each of them was loaded with provisions, weapons and everything necessary for a long journey.\r\n\r\nYou, Grand Duke, went out to the squad in battle armor. Your voice sounded confident and authoritative when you called on your warriors to be steadfast. You spoke of the greatness of Kiev, of the need to force Byzantium to recognize the power of Rus, and of the riches that await us in Constantinople."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Військо рушило вниз по Дніпру. Спершу пливли спокійно, розмірено, тримаючи бойовий порядок. Люди в човнах співали старовинні пісні, згадували перемоги минулих років. Це був момент, коли кожен відчував, що він — частина чогось більшого, ніж він сам.\r\n\r\nНа порогах Дніпра дружина показала свою витримку та злагодженість. Ти особисто слідкував за тим, як човни обережно обносилися по суші. Це була перша перевірка для всього війська, і вони її успішно витримали.",
                                            TextEng = "The army moved down the Dnieper. At first they sailed calmly, measuredly, maintaining battle order. People in boats sang old songs, remembered the victories of past years. It was a moment when everyone felt that they were a part of something bigger than themselves.\r\n\r\nOn the rapids of the Dnieper, the squad showed its endurance and coordination. You personally watched as the boats carefully swept along the land. This was the first test for the entire army, and they successfully passed it."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Після порогів війська дісталися до Чорного моря. Там тебе зустрів свіжий вітер і простори, що тягнулися до самого обрію. Ти знав, що це лише початок великого шляху, і попереду — головне випробування, яке увійде в літописи як одна з найбільших перемог Київської держави.",
                                            TextEng = "After the rapids, the troops reached the Black Sea. There you were met by a fresh wind and expanses stretching to the very horizon. You knew that this was only the beginning of a great journey, and ahead was the main test, which would go down in the annals as one of the greatest victories of the Kyivan state."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "З наближенням до Константинополя напруга зростала. Місто було могутньою твердинею, захищеною високими мурами, але твої воїни не знали страху. Приставши до берега, ти одразу організував блокаду: численні човни заполонили узбережжя, а твої дружинники облягли підступи до міста.",
                                            TextEng = "As you approached Constantinople, the tension grew. The city was a mighty fortress, protected by high walls, but your soldiers knew no fear. Having landed on the shore, you immediately organized a blockade: numerous boats flooded the coast, and your warriors besieged the approaches to the city."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Бій за Константинополь",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 25000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 45
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Oleg"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "LevVIMudriy"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 14,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "На умовах, вигідних Києву, було укладено мир. Візантія зобов’язалася сплатити щедру данину — 12 гривень срібла на кожного руського воїна, що брав участь у поході. Окрім того, торгові угоди забезпечили київським купцям безпечний і вигідний доступ до ринків імперії.\r\n\r\nЯк символ перемоги твій щит, великий княже, був прибитий до воріт Константинополя. Цей акт став символом підкорення гордого міста волі Русі.",
                                            TextEng = "Peace was concluded on terms favorable to Kiev. Byzantium undertook to pay a generous tribute — 12 hryvnias of silver for each Rus’ soldier who took part in the campaign. In addition, trade agreements provided Kievan merchants with safe and profitable access to the empire’s markets.\r\n\r\nAs a symbol of victory, your shield, O Grand Duke, was nailed to the gates of Constantinople. This act became a symbol of the conquest of the proud city of the will of Rus’."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Олег, мудрий і далекоглядний княже, останні роки твого правління стали гідним продовженням твоєї славної долі. Ти не зупинився на досягненнях. Після тріумфу над Константинополем ти спрямував сили на зміцнення Київської держави та розширення її впливу.",
                                            TextEng = "Oleg, wise and far-sighted prince, the last years of your reign were a worthy continuation of your glorious destiny. You did not stop at your achievements. After the triumph over Constantinople, you directed your forces to strengthen the Kievan state and expand its influence."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти приділяв увагу встановленню миру на вже завойованих землях. Тиверці, сіверяни та древляни під твоїм мудрим керівництвом перетворилися з ворогів на вірних союзників. Ти встановив чіткі закони сплати данини, щоб не лише поповнювати скарбницю, а й зміцнювати зв'язки між племенами. Завдяки цьому Київська Русь почала перетворюватися на потужний державний організм, де кожне плем’я бачило свою роль у спільній справі.",
                                            TextEng = "You paid attention to establishing peace in the already conquered lands. The Tivertsi, Severians and Drevlyans under your wise leadership turned from enemies into loyal allies. You established clear laws for paying tribute in order not only to replenish the treasury, but also to strengthen ties between the tribes. Thanks to this, Kievan Rus began to transform into a powerful state organism, where each tribe saw its role in the common cause."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Description = "Згідно з переказами, твоє життя завершилося несподівано. Літописи згадують, що смерть прийшла до тебе у вигляді пророцтва, коли змія, символ неминучої долі, завдала тобі смертельного укусу. Цей момент став легендою, яка показує, що навіть наймогутніші князі не можуть уникнути вироку долі.",
                                        DescriptionEng = "According to legend, your life ended unexpectedly. Chronicles mention that death came to you in the form of a prophecy, when a snake, a symbol of inevitable fate, inflicted a fatal bite on you. This moment became a legend, showing that even the most powerful princes cannot escape the sentence of fate."
                                    }
                                },
                                new Turn()
                                {
                                    Id = 15,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після славного правління Олега, Київська держава отримала нового правителя — князя Ігоря, сина Рюрика. Його правління стало новою сторінкою в історії Русі, сповненою як викликів, так і досягнень. На відміну від свого попередника, Ігор успадкував могутню, але складну державу, яка потребувала як сильної руки, так і розумної дипломатії.",
                                            TextEng = "After the glorious reign of Oleg, the Kievan state received a new ruler - Prince Igor, the son of Rurik. His reign became a new page in the history of Rus, full of both challenges and achievements. Unlike his predecessor, Igor inherited a powerful but complex state that required both a strong hand and clever diplomacy."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "На початку свого правління Ігор зіткнувся з необхідністю зберегти єдність Русі, яку забезпечив Олег. Племена, що платили данину Києву, потребували постійного контролю, щоб уникнути бунтів і зрад. У той час на кордонах дедалі активніше діяли печеніги, які час від часу пробували свої сили у спробах атакувати. Ігор, хоча й не мав слави великого завойовника, показав себе майстром політичної гри: він посилював владу Києва не лише військовими походами, але й дипломатією.",
                                            TextEng = "At the beginning of his reign, Igor was faced with the need to preserve the unity of Rus, which Oleg had secured. The tribes that paid tribute to Kiev needed constant control to avoid rebellions and betrayals. At that time, the Pechenegs were increasingly active on the borders, and from time to time they tried their hand at attacks. Igor, although he did not have the glory of a great conqueror, showed himself to be a master of the political game: he strengthened the power of Kiev not only through military campaigns, but also through diplomacy."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Період правління Ігоря був також відзначений кількома визначними походами. Особливого значення набули його експедиції на Візантію. Перший великий похід у 941 році закінчився невдачею: візантійський «грецький вогонь» знищив частину його флоту, і Русь змушена була відступити. Проте Ігор не здався. У 944 році він зібрав нові сили і знову рушив до Константинополя. Цього разу справа закінчилася дипломатично: між Києвом і Візантією було укладено новий договір, вигідний для обох сторін. Ігор показав, що навіть поразка може стати основою для нових досягнень.",
                                            TextEng = "The period of Igor's reign was also marked by several notable campaigns. Of particular importance were his expeditions to Byzantium. The first major campaign in 941 ended in failure: Byzantine \"Greek fire\" destroyed part of his fleet, and Rus was forced to retreat. However, Igor did not give up. In 944, he gathered new forces and again set out for Constantinople. This time the matter ended diplomatically: a new treaty was concluded between Kiev and Byzantium, beneficial to both sides. Igor showed that even defeat can become the basis for new achievements."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Description = "Однак найбільшим викликом для Ігоря стала внутрішня політика. Його спроба збільшити данину з древлян у 945 році обернулася трагедією. Старійшини древлян, розлючені надмірними поборами, підняли повстання, яке завершилося смертю князя. Цей момент став переломним для Русі, а його наслідки — поштовхом для радикальних реформ, які згодом провела княгиня Ольга.",
                                        DescriptionEng = "However, Igor’s greatest challenge was domestic politics. His attempt to increase tribute from the Drevlyans in 945 ended in tragedy. The Drevlyan elders, angered by the excessive levies, revolted, resulting in the prince’s death. This moment was a turning point for Rus’, and its consequences were the impetus for the radical reforms later carried out by Princess Olga."
                                    }
                                },
                                new Turn()
                                {
                                    Id = 16,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Період правління Ольги, вдови Ігоря, став однією з найбільш визначних етапів в історії Київської Русі. Її правління виявилося не лише відновленням стабільності після трагічної смерті її чоловіка, але й періодом значних змін у внутрішній та зовнішній політиці держави.",
                                            TextEng = "The reign of Olga, Igor's widow, was one of the most significant periods in the history of Kievan Rus'. Her reign was not only a restoration of stability after the tragic death of her husband, but also a period of significant changes in the state's domestic and foreign policy."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Після смерті Ігоря Ольга стала регенткою при малолітньому синові Святославі. Хоча її роль початково обмежувалася функціями опіки, Ольга швидко продемонструвала свою рішучість і здатність до владарювання. Вона відразу ж зіткнулася з наслідками повстання древлян, що стало причиною загибелі її чоловіка. Ольга вирішила не пробачити їм цього і застосувала жорстокі репресії. Літописи описують її помсту як безпрецедентну. Вона спочатку використала дипломатичні прийоми, щоб заманити представників древлян до Києва, де їх було вбито. Потім вона організувала жорстоку кару, заподіяну самому племені, що ще раз показало її здатність діяти безжально, коли це було необхідно для зміцнення влади.",
                                            TextEng = "After Igor's death, Olga became regent for her young son Svyatoslav. Although her role was initially limited to guardianship, Olga quickly demonstrated her determination and ability to rule. She immediately faced the consequences of the Drevlyan uprising that had led to her husband's death. Olga decided not to forgive them and resorted to brutal repression. The chronicles describe her revenge as unprecedented. She first used diplomatic tactics to lure the Drevlyan representatives to Kiev, where they were killed. She then organized a brutal punishment inflicted on the tribe itself, which once again demonstrated her ability to act ruthlessly when necessary to consolidate power."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Однак, на відміну від жорстоких методів попередніх правителів, Ольга почала вводити нові адміністративні реформи. Однією з її основних заслуг було створення системи збору данини, яка замінила старі традиційні методи і забезпечила стабільний потік доходів у державну скарбницю. Ольга також упровадила нові міри для покращення адміністративного контролю на місцях, що дозволяло зменшити відцентрові сили та укріпити центр.",
                                            TextEng = "However, in contrast to the brutal methods of previous rulers, Olga began to introduce new administrative reforms. One of her main achievements was the creation of a tribute collection system that replaced the old traditional methods and ensured a stable flow of revenue to the state treasury. Olga also introduced new measures to improve administrative control at the local level, which allowed for the reduction of centrifugal forces and the strengthening of the center."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Важливим етапом її правління стало встановлення дипломатичних відносин з Візантією. Ольга, прагнучи зміцнити міжнародний статус Русі, вирушила до Константинополя в 957 році, ставши однією з перших великих княгинь, що уклали договір з імператором. Візантія погодилася знизити податки для київських купців і навіть надала спеціальні привілеї для руських торговців. Цей візит до Візантії не лише підвищив статус Ольги на міжнародній арені, але й зміцнив зв’язки між Київською Руссю та могутньою імперією.",
                                            TextEng = "An important stage of her reign was the establishment of diplomatic relations with Byzantium. Olga, seeking to strengthen the international status of Rus, went to Constantinople in 957, becoming one of the first grand duchesses to conclude an agreement with the emperor. Byzantium agreed to reduce taxes for Kievan merchants and even granted special privileges for Rus' traders. This visit to Byzantium not only increased Olga's status in the international arena, but also strengthened ties between Kievan Rus' and the powerful empire."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Також важливою подією стала християнізація Ольги. Хоча вона сама не прийняла християнство в той час, цей візит став початком духовної трансформації Київської Русі, яка під її владою все більше відкривалася для візантійської культури та релігії. Її дипломатичні зусилля в контексті християнства стали основою для пізнішого прийняття християнства Святославом та Володимиром.",
                                            TextEng = "Another important event was Olga's Christianization. Although she herself did not convert to Christianity at the time, this visit marked the beginning of a spiritual transformation of Kievan Rus', which under her rule increasingly opened up to Byzantine culture and religion. Her diplomatic efforts in the context of Christianity became the basis for the later adoption of Christianity by Svyatoslav and Volodymyr."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Однак після того, як Святослав став дорослим і повністю взяв владу в свої руки, Ольга більше не могла залишатися при владі. Вона залишила за собою важливі духовні та політичні функції, але її пряме правління завершилося. Святослав, прагнучи до військових завоювань і більш прагматичних рішень, не підтримував матір у її прагненні зберігати стабільність через дипломатію і внутрішні реформи. Відтак, Ольга поступилася своїми владними повноваженнями на користь сина, хоча й залишалася почесною і важливою фігурою в історії Русі.",
                                            TextEng = "However, after Svyatoslav became an adult and took full power into his own hands, Olga could no longer remain in power. She retained important spiritual and political functions, but her direct rule ended. Svyatoslav, striving for military conquests and more pragmatic decisions, did not support her mother in her desire to maintain stability through diplomacy and internal reforms. Therefore, Olga ceded her power to her son, although she remained an honorable and important figure in the history of Rus."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Ольга",
                                        Description = "Правління Ольги залишило великий слід, оскільки вона стала однією з перших, хто продемонстрував прагнення до розбудови держави через зовнішню політику, мирні переговори та адміністративні реформи. Її діяльність заклала підвалини для подальшого розширення і розвитку Київської Русі за часів Святослава та Володимира.",
                                        DescriptionEng = "Olga's reign left a great mark, as she was one of the first to demonstrate a commitment to state-building through foreign policy, peace negotiations, and administrative reforms. Her activities laid the foundation for the further expansion and development of Kyivan Rus' under Svyatoslav and Volodymyr."
                                    }
                                },
                                new Turn()
                                {
                                    Id = 17,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Становлення Святослава Ігоровича як правителя Київської Русі ознаменувалося періодом масштабних військових кампаній, відновленням контролю над ключовими територіями та формуванням його іміджу як видатного полководця. Його молодість пройшла під опікою матері, княгині Ольги, яка керувала державою до досягнення Святославом повноліття. Саме в цей період формувалася його політична ідеологія, зосереджена на військовій експансії та збереженні незалежності Київської Русі.",
                                            TextEng = "The rise of Svyatoslav Igorevich as the ruler of Kievan Rus was marked by a period of large-scale military campaigns, the restoration of control over key territories, and the formation of his image as an outstanding commander. His youth was spent under the care of his mother, Princess Olga, who ruled the state until Svyatoslav came of age. It was during this period that his political ideology was formed, focused on military expansion and preserving the independence of Kievan Rus."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Великий княже Святославе, перед нами стоїть завдання, яке несе честь і славу твоєму імені, але вимагає обережності й розрахунків. Землі в’ятичів, багаті лісами та річками, поки що перебувають під впливом хозар, тих, хто накладає свою руку на слов’янські племена і змушує їх платити данину. Чи це не образа для Києва? Ми не можемо дозволити, щоб наші брати залишалися під чужою владою, коли Русь має силу, щоб покласти цьому край.",
                                            TextEng = "Grand Prince Svyatoslav, we are faced with a task that brings honor and glory to your name, but requires caution and calculation. The lands of the Vyatichi, rich in forests and rivers, are still under the influence of the Khazars, those who lay their hands on the Slavic tribes and force them to pay tribute. Is this not an insult to Kiev? We cannot allow our brothers to remain under foreign rule, when Russia has the power to put an end to this."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Підготовка до походу починається з аналізу. В’ятичі — це не ворог у прямому сенсі, але їхні землі є частиною тієї системи, що годує хозар. У нашій силі розірвати цей ланцюг і привернути їх до Києва, не як ворогів, а як братів, які визнають твою силу і мудрість. Ми маємо діяти так, щоб захопити їхню увагу і повагу, а не лише здобути перемогу зброєю.",
                                            TextEng = "Preparation for the campaign begins with analysis. The Vyatichi are not an enemy in the literal sense, but their lands are part of the system that feeds the Khazars. It is in our power to break this chain and attract them to Kiev, not as enemies, but as brothers who recognize your strength and wisdom. We must act in such a way as to capture their attention and respect, and not just to win victory by arms."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Дружина готується до походу. Човни вже ладнають, бо річки поведуть нас до їхніх поселень. Залізо точиться, а серця воїнів розпалені. Ми несемо не лише меч, а й силу слова, силу впевненості в тому, що Київ є тим світлом, яке об’єднає всі слов’янські землі.\r\n\r\nПричина ясна: хозари вже занадто довго витискають данину з наших сусідів. Кожна монета, яку вони забирають, посилює їхні війська і послаблює наші. Вони панують у степах і тримають наш шлях до Каспійського моря. Але ми вже чуємо тріщину в їхній владі, і наш похід до в’ятичів — це перший удар по їхньому пануванню.",
                                            TextEng = "The wife is preparing for the campaign. The boats are already getting ready, because the rivers will lead us to their settlements. The iron is sharpened, and the hearts of the warriors are inflamed. We carry not only the sword, but also the power of the word, the power of the confidence that Kyiv is the light that will unite all the Slavic lands.\r\n\r\nThe reason is clear: the Khazars have been squeezing tribute from our neighbors for too long. Every coin they take strengthens their troops and weakens ours. They rule the steppes and hold our path to the Caspian Sea. But we already feel a crack in their power, and our campaign to the Vyatichi is the first blow to their rule."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Це не лише війна за данину чи землі. Це крок до того, щоб усі слов’яни бачили: Київ — не лише центр торгівлі, а й центр сили. Княже, твоя рішучість має вести нас. Вогонь, що горить у твоїх очах, запалить серця твоїх воїнів. Ми візьмемо ці землі без зайвого кровопролиття, але із чітким сигналом усім: Русь — єдина, і лише Київ — її серце.",
                                            TextEng = "This is not just a war for tribute or land. This is a step towards making all Slavs see: Kyiv is not only a center of trade, but also a center of power. Prince, your determination must guide us. The fire that burns in your eyes will ignite the hearts of your warriors. We will take these lands without unnecessary bloodshed, but with a clear signal to everyone: Rus is one, and only Kyiv is its heart."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Княже Святославе, наші люди готувалися до цього дня з великою напругою, але й з радісним нетерпінням. Настав час вирушати. Дружинники збираються на березі, де човни вже на воді, їхні весла готові розрізати холодні потоки річок. Мечі виблискують на сонці, а щити висять на бортах, немов обіцянка захисту і перемоги.",
                                            TextEng = "Prince Svyatoslav, our people have been preparing for this day with great tension, but also with joyful impatience. The time has come to set out. The warriors are gathering on the shore, where the boats are already in the water, their oars ready to cut the cold streams of the rivers. Swords glitter in the sun, and shields hang on the sides, like a promise of protection and victory."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Перший етап нашого походу — спуститися вниз за течією Десни, звідти увійти до глибоких земель в’ятичів. Військовий порядок чітко встановлено: у передньому човні ти, княже, сам, а за тобою йдуть десятки, що тримають у собі міць Русі. На чолі кінних загонів, що супроводжують нас уздовж берегів, стоять твої найдосвідченіші воїни. Вони пильнують кожну місцевість, кожну стежку, щоб ворог не зміг застати нас зненацька.",
                                            TextEng = "The first stage of our campaign is to descend downstream of the Desna River, from there to enter the deep lands of the Vyatichi. The military order is clearly established: in the front boat you, prince, are alone, and behind you are dozens who hold the power of Russia within themselves. At the head of the horse detachments that accompany us along the banks are your most experienced warriors. They guard every area, every path, so that the enemy cannot catch us by surprise."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Світанок приносить новий день, і з ним — наш рух. Люди на берегах кидають погляди на нашу армію, що пливе, наче жива ріка, готова знести все на своєму шляху. Веслярі гребуть у злагодженому ритмі, під вигуки ватажків. Їхня сила — не лише в руках, а й у вірі, що ми вирушаємо для великої справи.",
                                            TextEng = "Dawn brings a new day, and with it our movement. People on the banks glance at our army, which flows like a living river, ready to sweep away everything in its path. The rowers row in a harmonious rhythm, to the shouts of their leaders. Their strength is not only in their hands, but also in the belief that we are setting out for a great cause."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Вода несе нас ближче до в’ятицьких поселень. Згодом відчуємо, чи зустрінуть вони нас із покорою, чи випробують нашу зброю. Але поки що тиша над водою, порушена лише шелестом весел і криками птахів. Наче сама природа затамувала подих перед нашою подорожжю.",
                                            TextEng = "The water carries us closer to the Vyatka settlements. Later we will feel whether they will meet us with humility or test our weapons. But for now, the silence over the water is broken only by the rustle of oars and the cries of birds. It is as if nature itself has held its breath before our journey."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "Ти, княже, стоїш на носі свого човна, вдивляючись у далину. Твій погляд пильний, твоя рука впевнено тримає руків’я меча. Люди бачать тебе і знають, що за таким князем їм нема чого боятися. Із таким лідером Русь стає сильнішою з кожним днем, із кожною битвою, із кожним походом.",
                                            TextEng = "You, prince, stand on the bow of your boat, peering into the distance. Your gaze is watchful, your hand confidently holds the hilt of your sword. People see you and know that behind such a prince they have nothing to fear. With such a leader, Russia becomes stronger with every day, with every battle, with every campaign."
                                        },
                                        new Content()
                                        {
                                            Id = 10,
                                            Text = "Коли ми наблизилися до першого великого поселення в’ятичів, надійшли розвідники з повідомленням: місцеві не готові прийняти нашу владу без опору. Вони зібрали ополчення — кілька сотень досвідчених воїнів, загартованих життям у складних умовах, які готувалися зустріти нас у лісах. Їхній чисельності вистачило б, щоб створити проблему для необачного командира, але не для тебе, княже.",
                                            TextEng = "As we approached the first large settlement of the Vyatichi, scouts arrived with a message: the locals were not ready to accept our power without resistance. They gathered a militia - several hundred experienced warriors, hardened by life in difficult conditions, who were preparing to meet us in the forests. Their numbers would be enough to create a problem for a reckless commander, but not for you, prince."
                                        },
                                        new Content()
                                        {
                                            Id = 11,
                                            Text = "Твоя дружина, добре організована і дисциплінована, оточила поселення, не залишаючи шансів для втечі. Ти звернувся до в’ятичів із вимогою здатися й присягнути Києву. Сильний голос твоєї волі змусив багатьох вагатися. Проте їхні лідери вирішили випробувати нашу силу.\r\n\r\nПерша сутичка сталася на околиці лісу. Наші щитоносці зустріли стріли в’ятичів стіною, а потім, під твоїм наказом, розпочали організований наступ. Відвага і стратегія перемогли чисельність і знання місцевості. Вороги, побачивши, як падають їхні товариші, почали відступати.",
                                            TextEng = "Your army, well organized and disciplined, surrounded the settlement, leaving no chance for escape. You turned to the Vyatichi with a demand to surrender and swear allegiance to Kiev. The strong voice of your will made many hesitate. However, their leaders decided to test our strength.\r\n\r\nThe first skirmish took place on the edge of the forest. Our shield-bearers met the Vyatichi arrows with a wall, and then, under your command, launched an organized attack. Courage and strategy defeated numbers and knowledge of the terrain. The enemies, seeing their comrades fall, began to retreat."
                                        },
                                        new Content()
                                        {
                                            Id = 12,
                                            Text = "Княже, твоя міць і холодна рішучість у цей день вразили навіть ворогів. Коли основна битва була завершена, ти знову звернувся до в’ятичів. Цього разу твої слова були прийняті з покорою. В’ятицькі лідери вийшли зі своїх укріплень і схилили голови перед тобою, визнаючи твою владу.\r\n\r\nМирні переговори пройшли швидко. В’ятичі погодилися припинити данину хозарам і визнати себе частиною Київської держави. Ти залишив частину своєї дружини для нагляду й організації нових порядків, а сам вирушив далі, залишивши за собою не страх, а повагу.",
                                            TextEng = "Prince, your strength and cold determination on that day amazed even your enemies. When the main battle was over, you again addressed the Vyatichi. This time your words were received with humility. The Vyatichi leaders came out of their fortifications and bowed their heads before you, recognizing your authority.\r\n\r\nPeace negotiations were swift. The Vyatichi agreed to stop paying tribute to the Khazars and recognize themselves as part of the Kievan state. You left part of your squad to supervise and organize new orders, and you yourself set off, leaving behind not fear, but respect."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Становлення Святослава",
                                        Description = "Цей похід не лише розширив межі Русі, а й став сигналом для хозар: їхній вплив слабшає. Тепер перед нами відкриваються нові горизонти, і твої плани, княже, вже розгортаються в уяві, як наступний крок великого завоювання.",
                                        DescriptionEng = "This campaign not only expanded the borders of Russia, but also became a signal to the Khazars: their influence is weakening. Now new horizons are opening before us, and your plans, prince, are already unfolding in the imagination, as the next step of the great conquest.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 18,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Під вечір, коли сонце опускалося за обрій, в твоєму наметі панувала напружена тиша. Розвідники доповіли: печеніги готові до перемовин. Це були ті самі кочовики, чиї наскоки завдавали великих збитків сусідам. Їхня стрімка кіннота могла обернутися як проти Києва, так і на твою користь, Олегу. Але якою ціною?",
                                            TextEng = "In the evening, as the sun sank below the horizon, a tense silence reigned in your tent. The scouts reported: the Pechenegs were ready for negotiations. These were the same nomads whose raids had caused great damage to their neighbors. Their swift cavalry could turn against Kyiv as well as in your favor, Oleg. But at what cost?"
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Перед тобою постав вибір. Мир із ними міг забезпечити спокій на східних кордонах, давши змогу зосередити всю увагу на хозарах. Проте чи можна довіряти тим, хто поважає лише силу? Їхня згода на ненапад може стати тимчасовим тріумфом, але чи не стане вона пасткою в майбутньому?",
                                            TextEng = "You have a choice to make. Peace with them could bring peace to the eastern borders, allowing you to focus all your attention on the Khazars. But can you trust those who respect only strength? Their agreement to non-aggression may be a temporary triumph, but will it not become a trap in the future?"
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "З іншого боку, ти міг обрати інший шлях — не домовлятися, а діяти рішуче. Відкрита війна з печенігами показала б твою міць усім сусіднім племенам. Але чи варто було ризикувати, коли головна битва попереду, і твоїм справжнім ворогом залишається Хозарський каганат?",
                                            TextEng = "On the other hand, you could have chosen another path - not to negotiate, but to act decisively. An open war with the Pechenegs would have shown your power to all neighboring tribes. But was it worth the risk when the main battle was ahead, and your real enemy remained the Khazar Khaganate?"
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "А ще був третій варіант: домовленість із болгарами, які прагнуть послабити хозар. Їхній торговий інтерес збігався з твоїм бажанням зміцнити економічну базу Києва. Вони могли стати надійними союзниками, але чи буде достатньо їхньої підтримки, якщо печеніги раптом змінять позицію?",
                                            TextEng = "And there was a third option: an agreement with the Bulgarians, who sought to weaken the Khazars. Their commercial interest coincided with your desire to strengthen the economic base of Kiev. They could become reliable allies, but would their support be enough if the Pechenegs suddenly changed their position?"
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "У цей момент, великий княже, ти стояв перед вирішальним вибором. Важкі думки та холодний розрахунок супроводжували тебе, бо доля Києва залежала не лише від сили меча, а й від мудрості твоїх рішень.",
                                            TextEng = "At this moment, great prince, you were faced with a crucial choice. Heavy thoughts and cold calculation accompanied you, because the fate of Kyiv depended not only on the power of the sword, but also on the wisdom of your decisions."
                                        }
                                    },
                                    Choises = new List<Choise>()
                                    {
                                        new Choise()
                                        {
                                            Id = 0,
                                            Name = "Дипломатія",
                                            Elements = new List<ElementChoise>()
                                            {
                                                new ElementChoise()
                                                {
                                                    Id = 0,
                                                    Name = "Мир із печенігами",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 6500
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -300
                                                        }
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 1,
                                                    Name = "Домовленість із болгарами",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 12500
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -500
                                                        }
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 2,
                                                    Name = "Ні з ким не домовлятися",
                                                    Result = new List<Parametrs>()
                                                    {

                                                    }
                                                }
                                            }
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "965",
                                        Description = "Підготовка до перемовин завершувалася, і всі рішення, великокняже, тепер лежали на твоїх плечах. Посли печенігів, чи, можливо, болгари або інші союзники, вже чекали на твоє слово, вірячи у твою мудрість і силу. Ти стояв перед вибором, що міг визначити майбутнє не лише твого правління, а й самої Русі.\r\n\r\nЧоловіки у дружині готували свої обладунки, а радники шепотіли про важливість кожного слова на цих переговорах. Хтось радив обережність, аби не спровокувати нові конфлікти, інші ж закликали до рішучості, аби нав’язати умови, які б принесли найбільшу користь Києву.",
                                        DescriptionEng = "The preparations for the negotiations were being completed, and all decisions, Grand Duke, now lay on your shoulders. The ambassadors of the Pechenegs, or perhaps the Bulgarians or other allies, were already waiting for your word, believing in your wisdom and strength. You were faced with a choice that could determine the future not only of your reign, but also of Rus' itself.\r\n\r\nThe men in the squad prepared their armor, and the advisors whispered about the importance of every word in these negotiations. Some advised caution so as not to provoke new conflicts, while others called for decisiveness in order to impose conditions that would bring the greatest benefit to Kiev.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 20
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 19,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Княже Святославе, перед нами стоїть величезне завдання: ударити по серцю хозарської могутності, щоб раз і назавжди зруйнувати їхній вплив на наші землі. Це не просто війна за владу, це боротьба за майбутнє Русі, за свободу торгівлі та єдність наших земель. Успіх у цій кампанії залежить від ретельної підготовки, де кожна деталь має значення.",
                                            TextEng = "Prince Svyatoslav, we face a huge task: to strike at the heart of the Khazar power in order to destroy their influence on our lands once and for all. This is not just a war for power, it is a struggle for the future of Rus, for freedom of trade and the unity of our lands. Success in this campaign depends on careful preparation, where every detail matters."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Ми зібрали дружину, загартовану в боях, але цього разу перед нами не лише численні вороги, але й складні умови походу. Хозарські землі лежать далеко, через дикі степи та непрохідні ліси. Важливо забезпечити постійне постачання провізії, води та зброї. Підготовка складів і баз уздовж маршруту — це ключ до нашого успіху.",
                                            TextEng = "We have gathered a battle-hardened squad, but this time we face not only numerous enemies, but also difficult conditions for the campaign. The Khazar lands lie far away, across wild steppes and impenetrable forests. It is important to ensure a constant supply of provisions, water, and weapons. Preparing warehouses and bases along the route is the key to our success."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Кожен воїн, кожен кінь, кожна зброя має бути готова до тривалого походу. Майстри-ковалі день і ніч кують нові мечі та списи. Стрільці готують стріли, покриті міцними наконечниками, здатними пробивати ворожі обладунки. Дерев’яні щити зміцнені залізними обводами, аби витримати навіть найсильніший удар.",
                                            TextEng = "Every warrior, every horse, every weapon must be ready for a long campaign. Master blacksmiths work day and night to forge new swords and spears. Archers prepare arrows covered with strong tips capable of piercing enemy armor. Wooden shields are reinforced with iron rims to withstand even the strongest blow."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Ми також відправили розвідників, щоб зібрати дані про місце розташування хозарських сил і стан їхніх фортець. Звістки повертаються тривожні: хозари хоч і ослаблені, але все ще зберігають міцні укріплення. Ітіль, їхня столиця, залишається головним центром їхньої влади, а Саркел — фортецею, яка контролює важливий шлях через Дон.",
                                            TextEng = "We have also sent scouts to gather information on the location of the Khazar forces and the condition of their fortresses. The news is alarming: the Khazars, although weakened, still maintain strong fortifications. Itil, their capital, remains the main center of their power, and Sarkel is a fortress that controls the important route across the Don."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка",
                                        Description = "Перед відходом ти, княже, скликав віче, щоб виголосити промову. Твої слова про необхідність звільнити Русь від хозарського гніту запалили серця воїнів. \"Іду на ви!\" — сказав ти, і це стало закликом до великого походу, який змінить долю нашої землі.",
                                        DescriptionEng = "Before leaving, you, prince, convened a council to deliver a speech. Your words about the need to free Russia from Khazar oppression ignited the hearts of the soldiers. \"I'm coming for you!\" you said, and this became a call to a great campaign that would change the fate of our land.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 20
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 20,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Перші дні походу були стрімкими. Дружина рухалася вниз по Дону, уникаючи засідок і залишаючи після себе шляхи постачання. Хозари, які звикли до тривалих прикордонних сутичок, не очікували такого злагодженого та стрімкого удару.",
                                            TextEng = "The first days of the campaign were rapid. The army moved down the Don, avoiding ambushes and leaving supply routes behind. The Khazars, accustomed to prolonged border skirmishes, did not expect such a coordinated and rapid attack."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Княже, перед штурмом Саркела, ти і твої вірні радники ретельно обдумали кожен крок. Ворог мав численну перевагу за стінами, але ти добре розумів: це не лише битва за фортецю, а й за честь і владу Русі. У стінах твоєї ставки вирувала підготовка до вирішального удару.",
                                            TextEng = "Prince, before the storming of Sarkel, you and your faithful advisors carefully considered every step. The enemy had a numerical advantage behind the walls, but you understood well: this was not only a battle for the fortress, but also for the honor and power of Russia. Within the walls of your headquarters, preparations for the decisive blow were raging."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Насамперед ти зібрав воєвод і розвідників, аби вислухати останні доповіді про розташування ворога та стан його оборони. Розвідники повідомили: Саркел добре укріплений, його стіни високі й товсті, але хозари не готові до довготривалої облоги, адже в їхніх запасах мало провіанту. Твій геній проявився в тому, що ти обрав штурм як швидкий і рішучий спосіб зламати їхній спротив.",
                                            TextEng = "First of all, you gathered the voivode and scouts to listen to the latest reports on the enemy's location and the state of their defenses. The scouts reported: Sarkel is well fortified, its walls are high and thick, but the Khazars are not prepared for a long siege, as their supplies are few. Your genius was manifested in the fact that you chose an assault as a quick and decisive way to break their resistance."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Воїни дружно взялися за виготовлення осадних знарядь. У лісах, неподалік від фортеці, твої люди будували тарани, обшивали їх шкірою для захисту від вогню, майстрували штурмові сходи й укріплювали щити для стрільців. Серед твоїх дружинників кипіла робота, адже кожен розумів: від цих знарядь залежить доля бою.",
                                            TextEng = "The warriors unitedly set about making siege weapons. In the forests near the fortress, your men built battering rams, sheathed them with leather to protect them from fire, crafted assault ladders, and fortified shields for the archers. Work was in full swing among your warriors, for everyone understood that the fate of the battle depended on these weapons."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Варягам, які славилися своєю відвагою, ти доручив вести передовий удар по головних воротах. Їхній досвід у битвах гарантував, що вони зламають перший рубіж ворога. Печенізькі вершники, твої тимчасові союзники, мали завдання блокувати будь-які спроби хозарських загонів вийти з фортеці чи отримати підкріплення. Ти також підготував слов’янські загони для підтримки основного штурму та захисту флангів.",
                                            TextEng = "You tasked the Varangians, renowned for their courage, with leading the charge against the main gate. Their experience in battle guaranteed that they would break through the enemy’s first line. The Pecheneg horsemen, your temporary allies, were tasked with blocking any attempts by the Khazar troops to leave the fortress or to obtain reinforcements. You also prepared Slavic troops to support the main assault and protect the flanks."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Перед боєм ти сам обійшов своїх воїнів, звертаючись до них зі словами, які розпалювали їхній бойовий дух. Ти нагадував їм, що цей похід не лише за багатства, але й за славу Русі, за те, щоб знищити хозарське ярмо, яке гнітило слов’янські племена.",
                                            TextEng = "Before the battle, you yourself went around your soldiers, addressing them with words that inflamed their fighting spirit. You reminded them that this campaign was not only for wealth, but also for the glory of Rus, to destroy the Khazar yoke that oppressed the Slavic tribes."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Твоя армія чекала світанку, затаївши подих. Воїни, закутані в хутра, грілися біля багать, востаннє перевіряли зброю й молилися своїм богам про перемогу. А ти, княже, стояв на чолі війська, готовий вести його до великої слави.",
                                            TextEng = "Your army waited with bated breath for dawn. Warriors, wrapped in furs, warmed themselves by the fires, checking their weapons one last time and praying to their gods for victory. And you, prince, stood at the head of the army, ready to lead it to great glory."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Бій під Саркело",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 5000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 40
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Sviatoslav"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 21,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Княже Святославе, твоя перемога під Саркелом відкрила нову главу в історії цього великого походу. Після того як наші воїни подолали стіни фортеці, хозарський гарнізон був розбитий, а мешканці Саркела—підкорені. Ця твердиня, що довгий час служила ключовим пунктом оборони Хозарського каганату, тепер стала нашим оплотом. Русь затвердила свій контроль над важливим торговим і стратегічним вузлом.",
                                            TextEng = "Prince Svyatoslav, your victory at Sarkel opened a new chapter in the history of this great campaign. After our warriors overcame the walls of the fortress, the Khazar garrison was defeated, and the inhabitants of Sarkel were subdued. This stronghold, which had long served as a key point of defense of the Khazar Khaganate, has now become our stronghold. Rus' has consolidated its control over an important trade and strategic hub."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Окрім захоплення фортеці, ти розпорядився зміцнити її оборону, адже це місце стане важливим опорним пунктом для подальших дій. Дружинники зайнялися підготовкою Саркела до зими: поповненням запасів, облаштуванням приміщень для військових і налагодженням комунікацій з навколишніми територіями.",
                                            TextEng = "In addition to capturing the fortress, you ordered to strengthen its defenses, as this place would become an important stronghold for further actions. The Druzhinniki began preparing Sarkel for winter: replenishing supplies, arranging premises for the military, and establishing communications with the surrounding territories."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Місцеве населення — алани та інші підкорені племена, що залежали від хозарів, — визнало твою владу. Їм було запропоновано сплачувати данину Києву, замість колишніх хозарських правителів. Це не лише послабило економічний вплив хозар, а й підсилило твій авторитет серед сусідніх племен.",
                                            TextEng = "The local population — the Alans and other conquered tribes dependent on the Khazars — recognized your authority. They were offered to pay tribute to Kiev, instead of the former Khazar rulers. This not only weakened the economic influence of the Khazars, but also strengthened your authority among neighboring tribes."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Новина про падіння Саркела швидко розійшлася по всій Хозарії, сіючи паніку серед їхніх залишкових військ і підвладних народів. Це був початок кінця для їхнього панування в регіоні. Однак, попереду тебе чекала складна кампанія, адже головний удар мав бути спрямований на столицю каганату — Ітіль. Але ти знав: розгром Хозарії — це не лише твоє завдання, а й обов’язок перед усім слов’янським світом.",
                                            TextEng = "The news of Sarkel's fall quickly spread throughout Khazaria, sowing panic among their remaining troops and subject peoples. It was the beginning of the end for their rule in the region. However, a difficult campaign awaited you ahead, as the main blow was to be directed at the capital of the Khaganate - Itil. But you knew: the defeat of Khazaria was not only your task, but also a duty to the entire Slavic world."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Ти рушив на схід уздовж Волги, спрямовуючи свої сили до серця каганату — столиці Ітіль. Ця місія була ризикованою, адже ти перетинав землі, де хозари ще зберігали контроль, хоча і втрачали силу. Річкові судна, які привели твої воїни, давали перевагу у швидкості пересування та у забезпеченні військ.",
                                            TextEng = "You marched east along the Volga River, directing your forces toward the heart of the Khaganate, the capital of Itil. This mission was risky, as you crossed lands where the Khazars still held sway, though their power was declining. The riverboats that your warriors brought with them gave them the advantage of speed and supply."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "У кожному місті, яке ти проходив, до тебе приєднувалися народи, які роками страждали під хозарським пануванням. Опір хозар ставав дедалі слабшим, адже їхня центральна влада не могла організувати ефективної оборони. Ворог втратив важливі ресурси, а падіння Саркела посіяло розбрат серед їхніх союзників.",
                                            TextEng = "In each city you passed, you were joined by peoples who had suffered for years under Khazar rule. The Khazar resistance became weaker and weaker, as their central government could not organize an effective defense. The enemy lost important resources, and the fall of Sarkel sowed discord among their allies."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Княже, день, коли твої полки зійдуться з ворогом, вже наближається. Підготовка до битви — це не лише зброя і воїни, це стан душі і розуму. Ворожі укріплення Ітіля, багатство їхнього міста та впертість їхніх правителів ставлять перед нами нові виклики. Але ми маємо все, щоб здолати цей останній бастіон хозарської сили.",
                                            TextEng = "Prince, the day when your regiments will meet the enemy is approaching. Preparation for battle is not only about weapons and warriors, it is a state of mind and soul. The hostile fortifications of Itil, the wealth of their city, and the stubbornness of their rulers pose new challenges. But we have everything to overcome this last bastion of Khazar power."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Спершу, ти наказав своїм розвідникам дослідити територію навколо Ітіля. Волга розливалася тут у десятки рукавів, створюючи складний лабіринт, але це також надавало можливості. Наші човни, створені на Дніпрі, здатні маневрувати у цих водах, дозволяючи нам атакувати з несподіваного напрямку. Розвідка принесла звістки про те, що хозари не змогли зібрати великих сил для оборони. Їхні найманці розбіглися, їхні союзники зрадили. Але це не причина для недооцінки — залишки їхньої армії ще можуть чинити опір.",
                                            TextEng = "First, you ordered your scouts to explore the area around Itil. The Volga branched out into dozens of branches here, creating a complex labyrinth, but this also provided opportunities. Our boats, built on the Dnieper, are able to maneuver in these waters, allowing us to attack from an unexpected direction. The reconnaissance brought news that the Khazars were unable to gather large forces for defense. Their mercenaries had fled, their allies had betrayed. But this was no reason to underestimate - the remnants of their army could still resist."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Дружина готувалася наполегливо. Ладували зброю: сокири, списи, мечі. Лучники перевіряли тятиву, а ковалі зміцнювали залізо, яке стане щитом у бою. Ти особисто пройшов рядами своїх воїнів, вселяючи впевненість і нагадуючи кожному, що це не просто війна за багатства, а боротьба за свободу нашого народу від хозарського ярма.",
                                            TextEng = "The wife prepared diligently. Weapons were being prepared: axes, spears, swords. Archers checked the bowstring, and blacksmiths strengthened the iron that would become a shield in battle. You personally walked through the ranks of your warriors, inspiring confidence and reminding everyone that this was not just a war for wealth, but a struggle for the freedom of our people from the Khazar yoke."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "Твої радники обговорювали тактику. Основною ідеєю була швидкість і раптовість удару. Якщо ми зможемо розбити ворога до того, як він організує оборону, Ітіль стане нашим. Було вирішено використати річкові маршрути, щоб уникнути довгого шляху сушею і напасти несподівано, з води.",
                                            TextEng = "Your advisors discussed tactics. The main idea was speed and surprise of the attack. If we can defeat the enemy before he organizes a defense, Itil will be ours. It was decided to use the river routes to avoid the long journey overland and attack unexpectedly, from the water."
                                        },
                                        new Content()
                                        {
                                            Id = 10,
                                            Text = "Коли настав час вирушати, твої полки були готові до великого випробування. Армія зібралася на березі, човни ледь витримували вагу озброєних чоловіків. У повітрі пахло напругою, але кожен знав: сьогодні ми пишемо історію. Твої слова, звернені до дружини, звучали впевнено і сильно:\r\n\r\n— Руські воїни, сьогодні ми зламаємо останній ланцюг, що стримував нашу волю. Ми здобудемо перемогу або впадемо з честю. Ідімо на ви!",
                                            TextEng = "When the time came to set out, your regiments were ready for a great test. The army gathered on the shore, the boats could barely support the weight of armed men. The air smelled of tension, but everyone knew: today we are writing history. Your words, addressed to your wife, sounded confident and strong:\r\n\r\n— Ours warriors, today we will break the last chain that restrained our will. We will win or fall with honor. Let's go to you!"
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Ітіль",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 7000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 30
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Sviatoslav"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 22,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Княже, перемога під стінами Ітіля стала вирішальним кроком до занепаду Хозарського каганату. Після цього славного дня наші полки не затримувалися в зруйнованому місті надовго. Ітіль був спалений, і ті, хто залишився живими з його захисників, або присягнули на вірність, або втекли в степ, розповідаючи про нашу силу.",
                                            TextEng = "Prince, the victory at the walls of Itil was a decisive step towards the decline of the Khazar Khaganate. After this glorious day, our regiments did not linger in the ruined city for long. Itil was burned, and those who remained alive from its defenders either swore allegiance or fled to the steppe, telling about our power."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Твоя армія, княже, поповнилася новими союзниками. Деякі з хозарських васалів — буртаси, болгари на Волзі, навіть частина аланів — бачили в тобі визволителя від хозарського панування. Вони згодилися платити данину Києву і приєднали свої сили до нашої дружини. Твої бойові загони стали ще більшими, що дозволяло планувати нові великі походи.",
                                            TextEng = "Your army, prince, has been replenished with new allies. Some of the Khazar vassals - the Burtases, the Volga Bulgarians, even some of the Alans - saw in you a liberator from Khazar rule. They agreed to pay tribute to Kiev and joined their forces with our army. Your fighting units have become even larger, which allowed you to plan new major campaigns."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Здобич була чималою. Скрині, наповнені сріблом, тканинами й коштовностями, поповнили київські скарбниці. Але не багатства стали головною нагородою цього походу, а руйнування одного з найдавніших ворогів Русі. Хозарський каганат, колись могутній і жорстокий, був знищений як держава. В його місці залишилися лише розрізнені племена, що тепер боялися й згадували ім'я Святослава з тремтінням.",
                                            TextEng = "The booty was considerable. Chests filled with silver, fabrics and jewels filled the Kiev treasuries. But it was not wealth that became the main reward of this campaign, but the destruction of one of the oldest enemies of Russia. The Khazar Khaganate, once powerful and cruel, was destroyed as a state. In its place remained only scattered tribes, who now feared and remembered the name of Svyatoslav with trembling."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Твій похід приніс також славу Києву. Тепер тебе, княже, знали далеко за межами наших земель — від степу до Кавказу, від Болгарії до Візантії. Але ти не зупинився. Звістки про нашу перемогу лише спонукали ворогів готуватися до зустрічі з нами. Ти знав, що боротьба за утвердження Русі в світі лише починається.\r\n\r\nЗ цієї перемоги розпочалася нова епоха, коли ми стали господарями у цих краях. Але дух твій, княже, вже звертав погляд на інший край, де багатства й ворожі полчища чекають на тебе.",
                                            TextEng = "Your campaign also brought glory to Kiev. Now you, prince, were known far beyond our lands - from the steppe to the Caucasus, from Bulgaria to Byzantium. But you did not stop. The news of our victory only prompted the enemies to prepare to meet us. You knew that the struggle for the establishment of Rus in the world was only beginning.\r\n\r\nWith this victory, a new era began, when we became masters in these lands. But your spirit, prince, was already turning its gaze to another land, where riches and enemy hordes await you."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Княже, після знищення Хозарії ти не зупинився на досягнутому. Твої полки рушили далі на південь, у землі, де панували ясси та касоги. Ці народи були вірними союзниками Хозарського каганату й несли загрозу для нових завоювань Русі. Їхні землі — це ключ до Кавказу, багатого на шляхи та скарби. Без підкорення цих племен мир у наших нових володіннях залишався б недосяжним.",
                                            TextEng = "Prince, after the destruction of Khazaria, you did not stop there. Your regiments moved further south, into the lands where the Yass and Kasogs ruled. These peoples were loyal allies of the Khazar Khaganate and posed a threat to new conquests by Russia. Their lands are the key to the Caucasus, rich in roads and treasures. Without the subjugation of these tribes, peace in our new possessions would remain unattainable."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Кожен крок твоєї армії супроводжувався грізним шепотом серед ворогів. Ясси, що заселяли рівнини та підгір’я, намагалися зібрати сили, щоб протистояти тобі. Але їхнє військо, звикле до сутичок у тісних ущелинах, не витримало удару дружини, яка йшла, наче буря степом. Здобувши кілька перемог, ти зламав їхній опір. Вони склали зброю й підкорилися, визнавши владу Києва.",
                                            TextEng = "Every step of your army was accompanied by a menacing whisper among the enemies. The Iassi, who inhabited the plains and foothills, tried to gather strength to resist you. But their army, accustomed to battles in narrow gorges, could not withstand the blow of the squad, which was moving like a storm across the steppe. Having won several victories, you broke their resistance. They laid down their arms and submitted, recognizing the authority of Kiev."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Касоги, навчені досвідом своїх сусідів, спробували сховатися в гірських схилах, укріпивши свої селища. Але ти, княже, був безжальним. Своїми майстерними маневрами ти змусив їх вийти на бій. У запеклій битві касозька армія, хоч і численна, не змогла зрівнятися з твоїми дружинниками. Касоги втратили найкращих своїх воїнів, а їхні села стали частиною нашого володіння.",
                                            TextEng = "The Kasogs, taught by the experience of their neighbors, tried to hide in the mountain slopes, fortifying their villages. But you, prince, were ruthless. With your skillful maneuvers you forced them to come out to fight. In a fierce battle, the Kasog army, although numerous, could not match your warriors. The Kasogs lost their best warriors, and their villages became part of our possessions."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Тмуторокань, важливий вузол торгівлі, тепер належить нам. Цей успіх ще більше посилив славу твого імені, княже. Усі торгові шляхи, що вели з Кавказу до Причорномор’я, стали нашими. Тепер навіть Візантія дивиться на нас із тривогою, розуміючи, що вплив Русі поширюється все далі. Ти змінив хід історії, встановивши панування Києва там, де ще вчора хазяйнували хозари.",
                                            TextEng = "Tmutorokan, an important trading hub, now belongs to us. This success has further enhanced the glory of your name, prince. All the trade routes that led from the Caucasus to the Black Sea region have become ours. Now even Byzantium looks at us with anxiety, realizing that the influence of Russia is spreading further and further. You have changed the course of history, establishing the rule of Kiev where the Khazars ruled yesterday."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Княже Святославе, перед тим як ти звернув свій погляд на Балкани, світ навколо нас вже кипів інтригами й боротьбою. Перший виклик прийшов від Візантії, яка, занурена у внутрішні чвари, прагнула втримати контроль над Балканами. Болгарське царство, що довго трималося як могутня сила в регіоні, почало слабшати через конфлікти з сусідами і внутрішню нестабільність.",
                                            TextEng = "Prince Svyatoslav, before you turned your gaze to the Balkans, the world around us was already seething with intrigue and struggle. The first challenge came from Byzantium, which, mired in internal strife, sought to maintain control over the Balkans. The Bulgarian kingdom, which had long held its own as a powerful force in the region, began to weaken due to conflicts with its neighbors and internal instability."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "Імператор Візантії Костянтин VII, побоюючись посилення Болгарії, шукав нового союзника. Твоя репутація, княже, вже сягнула Балкан, і візантійські посли з’явилися у твоєму дворі, пропонуючи золото й союзи. Їхня пропозиція була простою: ти допомагаєш зломити Болгарію, а вони відкривають для тебе нові шляхи торгівлі й визнають твою силу. Вони сподівалися, що це буде звичайний удар і ти, виконавши завдання, повернешся до Києва.",
                                            TextEng = "The Byzantine Emperor Constantine VII, fearing the strengthening of Bulgaria, was looking for a new ally. Your reputation, prince, had already reached the Balkans, and Byzantine ambassadors appeared at your court, offering gold and alliances. Their offer was simple: you help break Bulgaria, and they open new trade routes for you and recognize your power. They hoped that this would be a normal blow and that you, having completed the task, would return to Kiev."
                                        },
                                        new Content()
                                        { 
                                            Id = 10,
                                            Text = "Але, княже, ти бачив більше. Балкани — це земля, де зустрічаються великі торговельні шляхи, де багатства пливуть з Константинополя на північ. Ти знав: контроль над цими землями відкриє перед Руссю нові горизонти. Ти почув заклик Візантії, але відповів не заради їхніх інтересів, а заради величі Русі.",
                                            TextEng = "But, prince, you have seen more. The Balkans are a land where great trade routes meet, where wealth flows from Constantinople to the north. You knew: control over these lands would open up new horizons for Rus. You heard the call of Byzantium, but you answered not for their interests, but for the greatness of Rus."
                                        },
                                        new Content()
                                        {
                                            Id = 11,
                                            Text = "Княже Святославе, підготовка до походу на Балкани вимагала не лише зібрання воїнства, а й продуманої стратегії, яка забезпечила б твоєму війську швидкість і рішучість. Твої думки були зосереджені на тому, щоб кожен рух армії відображав силу Русі та її готовність диктувати свої умови на Балканах.",
                                            TextEng = "Prince Svyatoslav, the preparation for the campaign in the Balkans required not only the gathering of troops, but also a well-thought-out strategy that would provide your army with speed and determination. Your thoughts were focused on ensuring that every movement of the army reflected the strength of Rus and its readiness to dictate its terms in the Balkans."
                                        },
                                        new Content()
                                        {
                                            Id = 12,
                                            Text = "Ти почав із того, що скликав найкращих воїнів зі всієї землі Руської. Дружинники, обстріляні в боях із хозарами й касогами, готові були виступити за твоїм наказом. Союзні племена, що вже визнавали твою владу, вислали свої загони, зміцнивши твою армію різноманіттям та числом.",
                                            TextEng = "You began by summoning the best warriors from all over the Russian land. The Druzhinniki, shelled in battles with the Khazars and Kasogs, were ready to act at your command. The allied tribes, who already recognized your authority, sent their detachments, strengthening your army with diversity and numbers."
                                        },
                                        new Content()
                                        {
                                            Id = 13,
                                            Text = "Проте, лише сила не була достатньою. Ти подбав про забезпечення війська. З Києва, Чернігова та інших міст ішли каравани з харчами, зброєю та запасами для довгого походу. Торгівці, які прагнули вигоди, приєднувалися до твоїх сил, сподіваючись знайти нові ринки на Балканах.",
                                            TextEng = "However, strength alone was not enough. You took care of the provision of the army. From Kyiv, Chernigov and other cities, caravans came with food, weapons and supplies for the long campaign. Merchants, eager for profit, joined your forces, hoping to find new markets in the Balkans."
                                        },
                                        new Content()
                                        {
                                            Id = 14,
                                            Text = "Твоя флотилія, яка вже не раз доводила свою ефективність, готувалася перетнути Чорне море. Кораблі ремонтували, зміцнювали, оснащували баллістами та іншими облоговими знаряддями. Ти розумів, що битви будуть не лише на суші, а й у водах, де твої веслярі й лучники стануть ключовою силою.",
                                            TextEng = "Your flotilla, which had already proven its effectiveness more than once, was preparing to cross the Black Sea. The ships were repaired, strengthened, equipped with ballistae and other siege weapons. You understood that the battles would be not only on land, but also in the waters, where your rowers and archers would become a key force."
                                        },
                                        new Content()
                                        {
                                            Id = 15,
                                            Text = "Перед виступом ти зібрав раду старійшин і воєвод. Кожен з них отримав чіткі накази. Армія мала рухатися швидко, захоплюючи стратегічні пункти й залишаючи гарнізони для утримання здобутого. Усі знали: мета — не просто перемогти Болгарію, а поставити на коліна ті сили, що могли б кинути виклик Русі.",
                                            TextEng = "Before the speech, you gathered a council of elders and a voivode. Each of them received clear orders. The army was to move quickly, capturing strategic points and leaving garrisons to hold what was gained. Everyone knew: the goal was not just to defeat Bulgaria, but to bring to its knees those forces that could challenge Rus."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка",
                                        Description = "Підготовка завершувалася молитвами й жертвоприношеннями богам. Священники благословляли воїнів, а ти, Святославе, дивився на свою армію з упевненістю. Цей похід мав стати не лише випробуванням твоєї сили, а й початком нової ери для Русі.",
                                        DescriptionEng = "The preparations were completed with prayers and sacrifices to the gods. The priests blessed the warriors, and you, Svyatoslav, looked at your army with confidence. This campaign was to be not only a test of your strength, but also the beginning of a new era for Rus.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 20
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 15000
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 23,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Княже Святославе, початок походу став дзвоном, що прокотився всією Руссю, оголошуючи твої наміри підкорити Балкани. Весна принесла пробудження не лише землі, а й твоєї армії. Льоди Дніпра танули, звільняючи шлях для твоєї флотилії, а зелень степів відкривала простори для руху кінноти.",
                                            TextEng = "Prince Svyatoslav, the beginning of the campaign became a bell that rang throughout Russia, announcing your intentions to conquer the Balkans. Spring brought the awakening not only of the land, but also of your army. The ice of the Dnieper melted, clearing the way for your flotilla, and the greenery of the steppes opened up spaces for the movement of cavalry."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Твоє військо, зібране в Києві, було наче живий організм: тисячі чоловіків, від старших дружинників до молодих новобранців, чекали твого сигналу до виступу. Бойові знамена піднімалися в небі, їхні кольори нагадували про твої перемоги над хозарами та іншими ворогами. Лучники перевіряли тятиви, а ковалі досі не випускали з рук молотів, готуючи останнє спорядження.",
                                            TextEng = "Your army, gathered in Kyiv, was like a living organism: thousands of men, from senior warriors to young recruits, awaited your signal to advance. Battle banners rose in the sky, their colors a reminder of your victories over the Khazars and other enemies. Archers checked their bowstrings, and blacksmiths still held hammers in their hands, preparing the last equipment."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти, великий княже, виступив попереду своєї дружини, вітром пронісши через лави слова: \"Іду на ви!\". Ці слова, ніби блискавка, збудили в кожному воїні жагу до перемоги. Ти знав, що не лише фізична сила, а й дух твого війська приведе до успіху.",
                                            TextEng = "You, the great prince, stepped forward in front of your wife, carrying the words through the ranks like the wind: \"I am coming for you!\". These words, like lightning, aroused in every warrior the thirst for victory. You knew that not only physical strength, but also the spirit of your army would lead to success."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Перше випробування — Чорне море. Твоя флотилія вирушила вниз Дніпром, несучи на собі не лише воїнів, а й надію на перемогу. На кожному судні — озброєні до зубів дружинники, готові зустріти ворога навіть серед хвиль. Веслярі злагоджено гнали кораблі вперед, підпорядковуючи свою силу твоєму плану.",
                                            TextEng = "The first test is the Black Sea. Your flotilla set off down the Dnieper, carrying not only warriors but also the hope of victory. On each ship were warriors armed to the teeth, ready to meet the enemy even among the waves. The rowers drove the ships forward in unison, subordinating their strength to your plan."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Назустріч тобі тягнулася територія Болгарії — земля, багата й водночас ослаблена внутрішніми розбратами. Болгарські вартові, побачивши твої судна на горизонті, поспішали з вістями до своїх правителів, але в їхніх очах уже був страх. Твоє військо входило до нового етапу, де кожен рух мав визначати хід історії.",
                                            TextEng = "The territory of Bulgaria stretched towards you - a land rich and at the same time weakened by internal strife. The Bulgarian sentries, seeing your ships on the horizon, hurried with news to their rulers, but there was already fear in their eyes. Your army was entering a new stage, where every move would determine the course of history."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Похід на Болгарію розгортався, як грандіозна драма, в якій кожен крок війська був викликом і тріумфом. Коли флотилія князя увійшла до вод Дунаю, болгарські землі вперше побачили руські знамена, що майоріли над хвилями. Святослав повів своє військо вперед, зустрічаючи невеликі загони противника, які намагалися перешкодити його просуванню. Вони були розбиті швидкими ударами, і шлях углиб Болгарії відкрився.",
                                            TextEng = "The campaign against Bulgaria unfolded like a grand drama, in which every step of the army was a challenge and a triumph. When the prince's flotilla entered the waters of the Danube, the Bulgarian lands first saw the Russian banners fluttering above the waves. Svyatoslav led his army forward, meeting small enemy detachments that tried to hinder his advance. They were defeated by quick strikes, and the way deep into Bulgaria was opened."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Перед вирішальною битвою під Переяславцем було відчутно, як напруга висить у повітрі. Святослав, зібравши своїх радників, розгорнув перед ними карту місцевості. Ми детально розглядали кожен вигин річок, кожен пагорб і долину, знаючи, що навіть найменша деталь може стати вирішальною у бою. Святослав сидів у центрі, зосереджений і впевнений, його очі горіли пристрастю до перемоги.",
                                            TextEng = "Before the decisive battle of Pereyaslavts, the tension was palpable. Sviatoslav, having gathered his advisers, unfolded a map of the area before them. We examined in detail every bend of the rivers, every hill and valley, knowing that even the smallest detail could be decisive in the battle. Sviatoslav sat in the center, focused and confident, his eyes burning with passion for victory."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Першим завданням було визначити слабкі місця болгарської армії. Ми отримали розвідувальні дані про їхнє розташування – височини навколо міста давали болгарам перевагу, але ми знали, що їхня оборона не ідеальна. Святослав ухвалив сміливе рішення: ударити не лише по центру, а й одночасно по флангах, що мало зламати бойовий порядок ворога.",
                                            TextEng = "The first task was to identify the weak points of the Bulgarian army. We had received intelligence on their location - the heights around the city gave the Bulgarians an advantage, but we knew that their defenses were not perfect. Svyatoslav made a bold decision: to strike not only at the center, but also at the flanks at the same time, which was supposed to break the enemy's battle formation."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Військо готувалося до ночі. Лучники перевіряли тятиву, варяги точили сокири, а кіннотники намагалися привчити коней до нічних маневрів. Святослав відвідував кожен загін, розмовляючи з воїнами. Його слова надихали: він не приховував, що битва буде жорстокою, але кожен відчував, що князь вірить у перемогу.",
                                            TextEng = "The army was preparing for the night. Archers checked their bowstrings, the Varangians sharpened their axes, and the cavalry tried to accustom their horses to night maneuvers. Svyatoslav visited each detachment, talking to the soldiers. His words were inspiring: he did not hide that the battle would be fierce, but everyone felt that the prince believed in victory."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "Під час останньої наради ми обговорили сигнали для початку атаки. Світло факелів мало вказувати на готовність обхідних загонів, а клич, що лунатиме долиною, стане сигналом для центрального удару. Святослав ще раз повторив: «Дисципліна – ось наш щит, а злагодженість – наш меч».",
                                            TextEng = "During the last meeting, we discussed the signals for the start of the attack. The light of the torches was to indicate the readiness of the outflanking detachments, and the cry that would echo through the valley would be the signal for the central attack. Svyatoslav repeated once again: “Discipline is our shield, and harmony is our sword.”"
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Переяславець",
                                        Description = "Перед світанком всі були на позиціях. Тиша перед боєм була майже нестерпною, але водночас давала відчуття єдності. Кожен знав свою роль, а погляди були спрямовані на князя, який стояв у передньому ряду, готовий особисто повести військо в атаку.",
                                        DescriptionEng = "Before dawn, everyone was in position. The silence before battle was almost unbearable, but at the same time it gave a sense of unity. Everyone knew their role, and their eyes were fixed on the prince, who stood in the front row, ready to personally lead the army into the attack.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 30000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 60
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 60
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Sviatoslav"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "PetroI"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 24,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Захопивши Переяславець, ти, Великий княже Святославе, заклав основу для панування над багатими землями Балкан. Але ця перемога, хоч і славна, принесла не лише здобутки, а й нові виклики, що вимагали твоєї рішучої руки.",
                                            TextEng = "By capturing Pereyaslavts, you, Grand Duke Svyatoslav, laid the foundation for dominion over the rich lands of the Balkans. But this victory, although glorious, brought not only achievements, but also new challenges that required your decisive hand."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Місто стало твоїм новим форпостом, символом сили Київської Русі на Дунаї. Тут перепліталися багатства світу: із заходу йшло золото та вино, зі сходу — прянощі й шовк, із півночі — хутро та мечі. Але саме тут почали збурюватися ворожі течії, що могли стати на заваді твоїм великим задумам.",
                                            TextEng = "The city became your new outpost, a symbol of the power of Kievan Rus on the Danube. The riches of the world intertwined here: from the west came gold and wine, from the east - spices and silk, from the north - furs and swords. But it was here that hostile currents began to stir, which could hinder your great plans."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Звідусіль посипалися звістки. Болгари, хоч і присягли на вірність, таємно плели інтриги. Візантія, не бажаючи миритися з втратою впливу, укладала союзи, готуючи пастки. А печеніги, підбурювані імператором Никифором, взялися облягати Київ, залишений без твоєї захисної десниці.",
                                            TextEng = "News poured in from everywhere. The Bulgarians, although they swore allegiance, secretly plotted. Byzantium, unwilling to accept the loss of influence, concluded alliances, preparing traps. And the Pechenegs, incited by Emperor Nikephoros, began to besiege Kiev, left without your protective right."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Ти ухвалив мудре рішення: залишивши воєвод охороняти Переяславець, ти рушив на захист матері міст руських. Та навіть у відступі твої дії зміцнили нашу славу: ніде ворог не посмів з'явитися відкрито, усюди бачив лише залишки твоєї сили.",
                                            TextEng = "You made a wise decision: leaving the voivode to guard Pereiaslavets, you set out to defend the mother of Russian cities. But even in retreat, your actions strengthened our glory: nowhere did the enemy dare to appear openly, everywhere he saw only the remnants of your strength."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Твоя відсутність дала ворогам на Балканах час на відновлення. Але навіть вони знають: твій меч, один раз піднятий, ніколи не падає без слави. І кожен день, що минає, лише наближає годину, коли ти знову вирушиш у бій, об'єднавши усі свої сили, щоб завершити те, що ти так велично розпочав.",
                                            TextEng = "Your absence has given your enemies in the Balkans time to recover. But even they know: your sword, once raised, never falls without glory. And each passing day only brings closer the hour when you will once again go into battle, uniting all your forces to complete what you so grandly began."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Далі, великий княже, події загострилися на всіх фронтах. Після твого повернення до Києва, де ти встиг зняти облогу печенігів і укріпити столицю, залишені на Балканах землі почали втрачати стабільність. Переяславець, хоча й був взятий, не став спокійною базою: Візантія не могла змиритися із твоєю присутністю так близько до Константинополя.",
                                            TextEng = "Then, Grand Duke, events escalated on all fronts. After your return to Kiev, where you managed to lift the siege of the Pechenegs and fortify the capital, the lands left in the Balkans began to lose stability. Pereyaslavts, although taken, did not become a peaceful base: Byzantium could not accept your presence so close to Constantinople."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Імператор Никифор II Фока почав готувати великий контрнаступ, підбурюючи місцеве населення до повстань і обіцяючи нагороди тим, хто виступить проти Русі. Болгари, які ще нещодавно складали присягу, почали задумувати зраду, сподіваючись відновити власну незалежність. Лише частина місцевої знаті лишалася вірною, бачачи в тобі визволителя від візантійського гніту.",
                                            TextEng = "Emperor Nicephorus II Phocas began preparing a major counteroffensive, inciting the local population to revolt and promising rewards to those who would oppose Rus. The Bulgarians, who had recently sworn allegiance, began to plot treason, hoping to restore their own independence. Only a part of the local nobility remained loyal, seeing in you a liberator from Byzantine oppression."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Ти, Святославе, не став зволікати. Розуміючи, що довге панування на Балканах потребує ще більшої військової присутності та нових союзників, ти вирішив зібрати сили для нового походу. У цей час тобі надійшла звістка від болгарського царя Бориса II, який зазнав тиску від Візантії й шукав твого захисту.",
                                            TextEng = "You, Svyatoslav, did not hesitate. Realizing that a long reign in the Balkans required an even greater military presence and new allies, you decided to gather forces for a new campaign. At this time, you received a message from the Bulgarian Tsar Boris II, who was under pressure from Byzantium and sought your protection."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "969",
                                        Description = "Отже, далі був новий похід, у якому ти знову довів, що є одним із найсильніших правителів своєї доби. Це була епоха, коли кожен бій, кожна угода й кожна перемога вписували твоє ім'я золотими літерами в історію Київської Русі.",
                                        DescriptionEng = "So, next was a new campaign, in which you once again proved that you were one of the strongest rulers of your time. It was an era when every battle, every agreement, and every victory inscribed your name in golden letters in the history of Kievan Rus.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 25,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Далі, великий княже, події загострилися на всіх фронтах. Після твого повернення до Києва, де ти встиг зняти облогу печенігів і укріпити столицю, залишені на Балканах землі почали втрачати стабільність. Переяславець, хоча й був взятий, не став спокійною базою: Візантія не могла змиритися із твоєю присутністю так близько до Константинополя.",
                                            TextEng = "Then, Grand Duke, events escalated on all fronts. After your return to Kiev, where you managed to lift the siege of the Pechenegs and fortify the capital, the lands left in the Balkans began to lose stability. Pereyaslavts, although taken, did not become a peaceful base: Byzantium could not accept your presence so close to Constantinople."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Імператор Никифор II Фока почав готувати великий контрнаступ, підбурюючи місцеве населення до повстань і обіцяючи нагороди тим, хто виступить проти Русі. Болгари, які ще нещодавно складали присягу, почали задумувати зраду, сподіваючись відновити власну незалежність. Лише частина місцевої знаті лишалася вірною, бачачи в тобі визволителя від візантійського гніту.",
                                            TextEng = "Emperor Nicephorus II Phocas began preparing a major counteroffensive, inciting the local population to revolt and promising rewards to those who would oppose Rus. The Bulgarians, who had recently sworn allegiance, began to plot treason, hoping to restore their own independence. Only a part of the local nobility remained loyal, seeing in you a liberator from Byzantine oppression."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти, Святославе, не став зволікати. Розуміючи, що довге панування на Балканах потребує ще більшої військової присутності та нових союзників, ти вирішив зібрати сили для нового походу. У цей час тобі надійшла звістка від болгарського царя Бориса II, який зазнав тиску від Візантії й шукав твого захисту.",
                                            TextEng = "You, Svyatoslav, did not hesitate. Realizing that a long reign in the Balkans required an even greater military presence and new allies, you decided to gather forces for a new campaign. At this time, you received a message from the Bulgarian Tsar Boris II, who was under pressure from Byzantium and sought your protection."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Твій задум був простим, але сміливим: остаточно підкорити Балкани та створити сильну базу для тривалого панування Київської Русі в цьому регіоні. Але для цього потрібно було не лише військо, а й дипломатія. Твоїм планам заважали не лише зовнішні вороги, а й внутрішні труднощі — необхідність укріплення Києва та контролю над іншими землями, щоб забезпечити стабільність на Русі.",
                                            TextEng = "Your plan was simple but bold: to finally conquer the Balkans and create a strong base for the long-term rule of Kievan Rus in this region. But this required not only the army, but also diplomacy. Your plans were hindered not only by external enemies, but also by internal difficulties - the need to strengthen Kiev and control other lands in order to ensure stability in Rus."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Підготовка до нового походу, великий княже, стала часом ретельного планування та мобілізації. Ворог був сильний, а ситуація хитка, тож кожен твій крок мав стати частиною величної стратегії.",
                                            TextEng = "The preparations for the new campaign, Grand Duke, were a time of careful planning and mobilization. The enemy was strong and the situation was precarious, so your every move had to be part of a grand strategy."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Ти почав із перевірки стану війська. Дружина, загартована в боях на Балканах і в степах, вимагала поповнення, адже попередні кампанії залишили свої сліди. Було наказано зібрати найкращих воїнів із навколишніх земель: варягів, слов’янських ратників, а також найняти легких кінних лучників серед кочовиків. Їхнє вміння швидко маневрувати було необхідним для боротьби з візантійськими і болгарськими військами.",
                                            TextEng = "You began by checking the condition of the army. The army, hardened in battles in the Balkans and the steppes, required replenishment, as previous campaigns had left their marks. It was ordered to gather the best warriors from the surrounding lands: Varangians, Slavic warriors, and also to recruit light horse archers from among the nomads. Their ability to quickly maneuver was necessary to fight the Byzantine and Bulgarian armies."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Поки йшло укріплення війська, ти особисто перевіряв стан човнів. Річковий флот — твоя головна зброя в кампаніях. Нові човни були легкими, швидкими і здатними долати як річкові, так і морські хвилі. У гирлах Дунаю та Дністра створювалися укріплені бази, що мали стати опорними пунктами для майбутньої кампанії.",
                                            TextEng = "While the army was being strengthened, you personally checked the condition of the boats. The river fleet was your main weapon in the campaigns. The new boats were light, fast, and capable of overcoming both river and sea waves. Fortified bases were created at the mouths of the Danube and Dniester, which were to become strongholds for the upcoming campaign."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Дипломатія також не стояла осторонь. Посланці вирушили до печенігів і аланів, аби забезпечити мир на тилах і можливість отримання підкріплень у разі потреби. Ти знав, що збереження союзу з ними дозволить зосередитися на головному противнику — Візантії.",
                                            TextEng = "Diplomacy was also not left out. Envoys went to the Pechenegs and Alans to ensure peace in the rear and the possibility of receiving reinforcements if necessary. You knew that maintaining an alliance with them would allow you to focus on your main enemy - Byzantium."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "У самій Русі ти посилив контроль, забезпечуючи безпеку Києва. Залишені гарнізони охороняли рубежі, щоб ворог не скористався твоєю відсутністю. До Києва було зібрано достатньо припасів, щоб забезпечити тривалу війну. Ти підготував усе для того, аби на Балканах Русь показала свою силу та витривалість.",
                                            TextEng = "In Rus' itself, you strengthened control, ensuring the security of Kyiv. The garrisons left behind guarded the borders so that the enemy would not take advantage of your absence. Enough supplies were gathered in Kyiv to ensure a long war. You prepared everything so that Rus' could show its strength and endurance in the Balkans."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "969",
                                        Description = "Коли все було готове, твої люди зібралися у великому таборі, очікуючи наказу вирушити. Ти стояв на високому пагорбі, дивлячись на своє військо, і розумів: цей похід вирішить долю не лише Балкан, а й престижу Київської Русі.",
                                        DescriptionEng = "When everything was ready, your men gathered in a large camp, awaiting the order to set out. You stood on a high hill, looking down at your army, and understood: this campaign would decide the fate not only of the Balkans, but also of the prestige of Kievan Rus.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = -200
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 25000
                                            },
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 26,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Похід розпочався із впевненого руху на південь. Твоє військо, великий княже, залишило базу біля гирла Дністра і річковими шляхами вирушило вглиб балканських земель. Флот, побудований для швидких маневрів, легко подолав спокійні води Дунаю, оминаючи місцеві укріплення. Кожен човен був наповнений воїнами, які жадали нових перемог.",
                                            TextEng = "The campaign began with a confident movement to the south. Your army, Grand Duke, left its base at the mouth of the Dniester and set off along the river routes deep into the Balkan lands. The fleet, built for quick maneuvers, easily crossed the calm waters of the Danube, bypassing local fortifications. Each boat was filled with warriors eager for new victories."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "На першому етапі походу військо зустріло незначний опір з боку болгарських гарнізонів, які були не готові до швидкого наступу. Твої варяги та слов'янські ратники штурмували декілька фортець, відкривши шлях углиб Болгарії. Хоругви Русі здіймалися на вежах переможених укріплень, а місцеві жителі вперше відчули силу Київської держави.",
                                            TextEng = "At the first stage of the campaign, the army met with little resistance from the Bulgarian garrisons, who were not ready for a quick offensive. Your Varangians and Slavic warriors stormed several fortresses, opening the way deep into Bulgaria. The banners of Rus rose on the towers of the defeated fortifications, and the local residents first felt the power of the Kievan state."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Головною метою був підхід до столиці Болгарії — Преслава. У серці цієї кампанії твоє військо продемонструвало бездоганну організацію: передові загони розвідували місцевість, основні сили рухалися впорядковано, а тилові частини забезпечували безпеку комунікацій і транспорт із припасами.",
                                            TextEng = "The main objective was to reach the Bulgarian capital, Preslav. At the heart of this campaign, your army demonstrated impeccable organization: advanced units scouted the terrain, the main forces moved in an orderly manner, and the rear units ensured the security of communications and the transport of supplies."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Великий княже, підготовка до битви за Преслав була випробуванням як для війська, так і для твоєї стратегії. Ти стояв перед серйозним завданням: зламати останній опір болгар, які сховалися за високими стінами столиці, захищаючи свої землі та честь.",
                                            TextEng = "Grand Duke, the preparations for the Battle of Preslav were a test for both your army and your strategy. You faced a serious task: to break the last resistance of the Bulgarians, who had taken refuge behind the high walls of the capital, defending their lands and honor."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "На самому початку ти наказав провести детальну розвідку місцевості. Твої гінці та варязькі розвідники дослідили укріплення Преслава, шляхи до нього, джерела води й можливі пастки. Високі мури, добре захищені башти та чисельність болгарської армії були викликом, але не нездоланним.",
                                            TextEng = "At the very beginning, you ordered a detailed reconnaissance of the area. Your messengers and Varangian scouts examined the fortifications of Preslav, the roads to it, the water sources and possible traps. The high walls, well-protected towers and the size of the Bulgarian army were a challenge, but not insurmountable."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Ти зібрав своє військо, до яких входили досвідчені дружинники, варяги й новоприєднані загони з підкорених земель. Зрозумівши, що облога може тривати довго, ти наказав організувати польові склади з продовольством і забезпечити стійкі постачання. Уся увага приділялася дисципліні та злагодженості дій.",
                                            TextEng = "You gathered your army, which included experienced warriors, Varangians, and newly joined units from conquered lands. Realizing that the siege could last a long time, you ordered the organization of field warehouses with food and ensuring stable supplies. All attention was paid to discipline and coordination of actions."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Особливу роль у підготовці відігравали твої майстри та інженери. Вони створили тарани, штурмові драбини й навіть катапульти, пристосовані для атаки на стіни Преслава. Одночасно було організовано тренування штурмових загонів, які готувалися до бою на вузьких вуличках і за стінами міста.",
                                            TextEng = "Your craftsmen and engineers played a special role in the preparations. They created battering rams, assault ladders, and even catapults adapted for attacking the walls of Preslav. At the same time, training was organized for assault units, which were preparing for battle in the narrow streets and behind the city walls."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Твої полководці обговорювали можливі тактичні варіанти. Варяги наполягали на раптовій нічній атаці, тоді як слов'янські старійшини пропонували поступову облогу й виснаження ворога. Ти вирішив поєднати ці підходи: ударити з несподіваного боку, але водночас оточити місто, відрізавши його від постачання.",
                                            TextEng = "Your commanders discussed possible tactical options. The Varangians insisted on a sudden night attack, while the Slavic elders suggested a gradual siege and exhaustion of the enemy. You decided to combine these approaches: strike from an unexpected direction, but at the same time surround the city, cutting it off from its supplies."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Перед боєм ти звернувся до своїх воїнів. У твоїх словах звучала впевненість і рішучість: перемога мала не лише принести багатства, а й зміцнити Русь як нову силу на Балканах. Воїни, натхненні твоїми промовами, вірили в успіх і були готові до битви, навіть якщо це вимагало найбільших жертв.",
                                            TextEng = "Before the battle, you addressed your soldiers. Your words were filled with confidence and determination: victory would not only bring wealth, but also strengthen Russia as a new power in the Balkans. The soldiers, inspired by your speeches, believed in success and were ready for battle, even if it required the greatest sacrifices.v"
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "Підготовка завершилася, і твоє військо стало перед воротами Преслава. Болгари знали, що час для перемовин минув, і були готові до останнього бою. Відлуння битви за ці стіни ще довго розходитиметься Балканами, проголошуючи велич твого імені.",
                                            TextEng = "The preparations were complete, and your army stood before the gates of Preslav. The Bulgarians knew that the time for negotiations was over, and they were ready for the final battle. The echoes of the battle for these walls will long echo through the Balkans, proclaiming the greatness of your name."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Преслава",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 20000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 60
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 60
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Sviatoslav"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "BorusII"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 27,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після битви за Преслав Святослав закріпив контроль над значною частиною Болгарії. Захоплення столиці мало далекосяжні наслідки, адже підкорення Преслава дало йому не лише військову перевагу, а й політичний контроль над багатою болгарською територією. Болгарський цар Борис II потрапив у залежність від київського князя, і Болгарія фактично стала підвладною Києву.",
                                            TextEng = "After the Battle of Preslav, Svyatoslav consolidated control over a large part of Bulgaria. The capture of the capital had far-reaching consequences, as the conquest of Preslav gave him not only a military advantage, but also political control over the rich Bulgarian territory. The Bulgarian Tsar Boris II fell into dependence on the Kievan prince, and Bulgaria effectively became subject to Kiev."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Преслав перетворився на новий опорний пункт для подальшої експансії на Балкани. Святослав почав інтегрувати болгарські війська до свого війська, зміцнюючи власну армію перед можливими зіткненнями з Візантією. Ця перемога дала йому можливість укріпити свої позиції в регіоні, продовжуючи свій амбітний план створення Балканської імперії.",
                                            TextEng = "Preslav became a new stronghold for further expansion into the Balkans. Svyatoslav began to integrate Bulgarian troops into his army, strengthening his own army for possible clashes with Byzantium. This victory gave him the opportunity to consolidate his position in the region, continuing his ambitious plan to create a Balkan empire."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Проте перемога принесла не лише славу, а й нові виклики. Візантія, яка уважно стежила за розвитком подій, почала готуватися до відпору. Для імперії було критично важливо не допустити, щоб Святослав утвердився на Балканах. Попереду чекали нові битви, і кожен крок на завойованій території вимагав обережності й стратегічного планування.",
                                            TextEng = "However, the victory brought not only glory, but also new challenges. Byzantium, which was closely following the development of events, began to prepare for a counterattack. It was critically important for the empire to prevent Svyatoslav from establishing himself in the Balkans. New battles awaited, and every step in the conquered territory required caution and strategic planning."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "У самому Києві звістка про перемогу викликала радість, але й настороженість. Занадто велика увага до балканських справ викликала невдоволення серед слов'янських союзників і деяких бояр, які побоювалися послаблення впливу Русі на північних територіях. Тим часом у Болгарії Святослав почав укріплювати адміністративну систему, створюючи передумови для тривалого утримання влади.",
                                            TextEng = "In Kiev itself, the news of the victory caused joy, but also caution. Too much attention to Balkan affairs caused discontent among Slavic allies and some boyars, who feared a weakening of Rus' influence in the northern territories. Meanwhile, in Bulgaria, Svyatoslav began to strengthen the administrative system, creating the prerequisites for a long-term hold on power."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Після захоплення Преслава та підкорення Болгарії Святославу довелося відновити сили й укріпити позиції перед новим викликом — Візантією, яка не могла змиритися з його присутністю на Балканах. Подальші події привели до початку великого протистояння між Руссю та Візантійською імперією.",
                                            TextEng = "After the capture of Preslav and the conquest of Bulgaria, Svyatoslav had to regain his strength and strengthen his position before a new challenge - Byzantium, which could not accept his presence in the Balkans. Subsequent events led to the beginning of a major confrontation between Rus' and the Byzantine Empire."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Святослав, продовжуючи інтегрувати болгарські ресурси, армію та території до свого впливу, зіткнувся із загрозою контрнаступу з боку імператора Іоанна Цимісхія. Візантійці розпочали ретельну підготовку до війни, залучаючи найманців, дипломатичні союзи й ресурси зі всіх куточків своєї імперії. Для Русі це означало загрозу втрати щойно завойованих територій та випробування на міцність Святославової армії.",
                                            TextEng = "Svyatoslav, continuing to integrate Bulgarian resources, army, and territory into his sphere of influence, faced the threat of a counteroffensive from Emperor John Tzimiskes. The Byzantines began careful preparations for war, drawing in mercenaries, diplomatic alliances, and resources from all corners of their empire. For Rus', this meant the threat of losing newly conquered territories and a test of the strength of Svyatoslav's army."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "У Болгарії князь організував управління й залишив свої гарнізони, щоб убезпечити завойовані землі. Паралельно з цим він почав готувати свій наступ на Візантію, який мав вирішити долю його амбіцій у регіоні. Але наступні події обіцяли бути складними: дві великі держави вступали в боротьбу, яка стане вирішальною для контролю над Балканами.",
                                            TextEng = "In Bulgaria, the prince organized the administration and left his garrisons to secure the conquered lands. In parallel, he began to prepare his attack on Byzantium, which was to decide the fate of his ambitions in the region. But the following events promised to be difficult: two great powers were entering into a struggle that would become decisive for control of the Balkans."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Попереду чекала історична битва, яка визначала долю не тільки Святославової Русі, а й майбутнього впливу Візантії в Східній Європі.",
                                            TextEng = "A historic battle lay ahead, which would determine the fate not only of Svyatoslav's Rus', but also of the future influence of Byzantium in Eastern Europe."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Святослав вирішив залишатися на Балканах, вважаючи, що відхід означав би втрату всього досягнутого. Він закріпився в Переяславці — ключовій фортеці, яка мала стратегічне значення для контролю над регіоном. Проте Візантія, використовуючи свою могутню армію та дипломатію, зуміла зібрати значні сили для наступу.",
                                            TextEng = "Svyatoslav decided to remain in the Balkans, believing that leaving would mean losing everything he had achieved. He established himself in Pereyaslavtsi, a key fortress that was strategically important for controlling the region. However, Byzantium, using its powerful army and diplomacy, managed to gather significant forces for an offensive."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "У 971 році імператор Іоанн Цимісхій особисто очолив похід проти Русі. Візантійці скористалися морською перевагою, відрізавши Русь від підкріплень із Києва. Святослав опинився в складній ситуації, коли його війська були змушені оборонятися проти переважаючих сил супротивника.",
                                            TextEng = "In 971, Emperor John Tzimiskes personally led a campaign against Rus'. The Byzantines took advantage of their naval superiority, cutting off Rus' from reinforcements from Kyiv. Svyatoslav found himself in a difficult situation, with his troops forced to defend themselves against superior enemy forces."
                                        },
                                        new Content()
                                        {
                                            Id = 10,
                                            Text = "Битви 971 року стали вирішальними. Найважливіше зіткнення відбулося біля Доростола, де Святослав і його дружина, оточені візантійцями, показали дивовижну стійкість і мужність. Попри численні втрати, князь уклав мир із Візантією, за яким йому дозволили повернутися до Києва за умови залишення Балкан.",
                                            TextEng = "The battles of 971 were decisive. The most important clash took place near Dorostol, where Svyatoslav and his army, surrounded by the Byzantines, showed amazing resilience and courage. Despite numerous losses, the prince concluded peace with Byzantium, according to which he was allowed to return to Kiev on condition that he leave the Balkans."
                                        },
                                        new Content()
                                        {
                                            Id = 11,
                                            Text = "Ця кампанія стала для Святослава фатальною. Виснажена армія вирушила назад, але по дорозі, у 972 році, князь загинув у засідці печенігів біля дніпровських порогів. Його смерть стала кінцем великої епохи завоювань, а Київська Русь знову зіткнулася з внутрішніми та зовнішніми викликами.",
                                            TextEng = "This campaign was fatal for Svyatoslav. The exhausted army set off back, but on the way, in 972, the prince died in an ambush by the Pechenegs near the Dnieper rapids. His death marked the end of the great era of conquests, and Kievan Rus' again faced internal and external challenges."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "972",
                                        Description = "Після смерті Святослава у 972 році Київська Русь увійшла в період внутрішніх чвар, що був зумовлений боротьбою за владу між його синами. Його старший син Ярополк отримав Київ, Олег — землі древлян, а молодший син Володимир, що був народжений від рабині Малуші, — Новгород.",
                                        DescriptionEng = "After Svyatoslav's death in 972, Kievan Rus' entered a period of internal strife, caused by a power struggle between his sons. His eldest son Yaropolk received Kyiv, Oleg the lands of the Drevlyans, and his youngest son Vladimir, who was born to a slave girl, Malusha, Novgorod.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = -200
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 20000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Підтримка еліти",
                                                Description = "Підтримка еліти — це ключовий параметр, що визначає рівень впливу соціальної та політичної еліти на армію. Висока підтримка еліти забезпечує армії кращу організацію, більш ефективне командування та доступ до передових тактичних і технологічних нововведень. Еліта може сприяти фінансуванню армії, забезпеченню ресурсами та вербуванню елітних підрозділів, що в свою чергу підвищує боєздатність і мобільність війська.\r\n\r\nОднак низький рівень підтримки еліти може призвести до погіршення морального стану військ, зменшення фінансування і навіть до виникнення внутрішніх конфліктів, що ускладнює ефективне керування армією. Враховуючи її значення, важливо підтримувати баланс між вимогами еліти та інтересами народу, аби не дати можливість розколоти внутрішню стабільність держави.",
                                                Value = -40
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Підтримка армії",
                                                Description = "Підтримка армії – цей параметр визначає рівень моральної та матеріальної підтримки, яку отримує ваша армія від населення, уряду та інших союзників. Високий рівень підтримки значно підвищує бойовий дух солдатів, мотивуючи їх до подвигів на полі бою, покращуючи ефективність у боях та знижуючи ймовірність дезертирства. Навпаки, низька підтримка може призвести до зниження морального стану, що негативно впливатиме на швидкість руху армії, точність атак і здатність витримувати довготривалі бої. Підтримка може змінюватися в залежності від внутрішньополітичної ситуації, економічного становища та результатів попередніх битв.",
                                                Value = -50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = -50
                                            },
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 28,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "У 977 році між Ярополком та Олегом розпочалася міжусобна війна, яка завершилася загибеллю Олега. Володимир, побоюючись нападу Ярополка, втік за море, але згодом повернувся із варязькою дружиною, щоб відвоювати свою владу. До 980 року він здолав Ярополка та став єдиновладним князем Київської Русі.",
                                            TextEng = "In 977, a civil war broke out between Yaropolk and Oleg, which ended with Oleg's death. Vladimir, fearing an attack from Yaropolk, fled overseas, but later returned with a Varangian army to regain his power. By 980, he had defeated Yaropolk and become the sole ruler of Kievan Rus'."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Володимир Великий почав правити в часи, коли Русь потребувала консолідації. Він провів реформу язичництва, спробувавши створити єдиний пантеон богів, але пізніше зрозумів, що язичницькі вірування не могли забезпечити політичної стабільності та єдності. Це призвело до його рішення прийняти християнство, що стало переломним моментом в історії Русі. Хрещення Володимира та його народу в 988 році зміцнило Русь як державу, інтегруючи її до кола християнських країн і забезпечивши духовну та культурну єдність.",
                                            TextEng = "Vladimir the Great began his reign at a time when Rus was in need of consolidation. He reformed paganism, attempting to create a single pantheon of gods, but later realized that pagan beliefs could not provide political stability and unity. This led to his decision to convert to Christianity, which was a turning point in the history of Rus. The baptism of Vladimir and his people in 988 strengthened Rus as a state, integrating it into the circle of Christian countries and ensuring spiritual and cultural unity."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Дорогий княже Ярославе, Після смерті нашого батька Володимира Великого в 1015 році Русь опинилася в стані небаченого потрясіння. Святополк, твій старший брат, що сидів у Турові, оголосив себе спадкоємцем Київського престолу, хоча знав, що батько заповів владу Борису, улюбленому синові.",
                                            TextEng = "Dear Prince Yaroslav, After the death of our father Vladimir the Great in 1015, Russia found itself in a state of unprecedented turmoil. Svyatopolk, your elder brother, who was sitting in Turov, declared himself heir to the Kiev throne, although he knew that his father had bequeathed power to Boris, his beloved son."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Святополк же вчинив страшне: зібравши своїх вірних, він найняв убивць, щоб ті позбавили життя Бориса, а згодом і Гліба. Їхня смерть стала жахливою плямою на історії нашої Русі. Святополк за це дістав ім’я \"Окаянний\", бо зрадив і сім’ю, і Божий закон.\r\n\r\nЗабравши Київ, Святополк почав правити залізною рукою, але влада його не була довгою. Адже ти, мудрий і справедливий, зібрав силу свою в Новгороді, шукаючи підтримки варягів, і виступив проти нього. Твій похід став неминучим, бо Русь не могла терпіти такого князя, що кров’ю родичів омив свій престол.",
                                            TextEng = "Svyatopolk did a terrible thing: having gathered his faithful, he hired assassins to take the lives of Boris, and later Gleb. Their death became a terrible stain on the history of our Rus. For this, Svyatopolk received the name \"The Accursed\", because he betrayed both his family and God's law.\r\n\r\nHaving taken Kiev, Svyatopolk began to rule with an iron fist, but his power was not long. After all, you, wise and just, gathered your strength in Novgorod, seeking the support of the Varangians, and went against him. Your campaign became inevitable, because Rus could not tolerate such a prince who washed his throne with the blood of his relatives."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Святополк, знаючи про твій наступ, шукав союзників. Спершу звернувся до печенігів, а згодом до польського короля Болеслава Хороброго, намагаючись втримати Київ. Його війна з тобою була лютою: зради, битви та інтриги заполонили ці роки. Він двічі повертав собі Київ, але кожного разу ти змушував його тікати.",
                                            TextEng = "Svyatopolk, knowing about your attack, was looking for allies. First he turned to the Pechenegs, and later to the Polish king Boleslav the Brave, trying to hold on to Kyiv. His war with you was fierce: betrayals, battles and intrigues filled these years. He twice regained Kyiv, but each time you forced him to flee."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Величний княже Ярославе,\r\n\r\nПеред тобою битва, яка вирішить долю Русі, і підготовка до неї має бути ретельною. Твій ворог, Святополк Окаянний, зібрав сили, шукаючи підтримки у польського короля Болеслава Хороброго. Але й ти не лишився осторонь, зміцнивши свій стан у Новгороді, де народ готовий підтримати справедливого князя.",
                                            TextEng = "Grand Prince Yaroslav,\r\n\r\nA battle lies before you that will decide the fate of Rus', and preparation for it must be thorough. Your enemy, Svyatopolk the Cursed, has gathered his forces, seeking support from the Polish king Boleslav the Brave. But you have not remained aloof, strengthening your position in Novgorod, where the people are ready to support the just prince."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Твоя підготовка почалася з посилення війська. Ти вирішив звернутися до варягів, найнявши досвідчених воїнів, які вже не раз доводили свою силу у битвах. Новгородці, сповнені ненависті до Святополка за його зраду, добровільно вступали до твоїх лав, прагнучи відновити порядок у землі батька.",
                                            TextEng = "Your preparation began with the strengthening of the army. You decided to turn to the Varangians, hiring experienced warriors who had already proven their strength in battles more than once. The Novgorodians, full of hatred for Svyatopolk for his betrayal, voluntarily joined your ranks, striving to restore order in their father's land."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Військо потрібно було озброїти: нові списи, міцні щити, мечі й луки стали основою озброєння твоїх людей. Ковалі Новгорода працювали вдень і вночі, забезпечуючи воїнів усім необхідним. Але найважливіше – ти скликав своїх старійшин і воєвод, щоб обміркувати стратегію.\r\n\r\nТвій план був простим, але хитрим: не дати Святополку зібрати сили в одному місці. Ти вирішив діяти швидко, завдаючи ударів по його позиціях, доки він ще не зміцнив своїх рядів.",
                                            TextEng = "The army needed to be armed: new spears, strong shields, swords and bows became the basis of your people's armament. The blacksmiths of Novgorod worked day and night, providing the soldiers with everything they needed. But most importantly, you summoned your elders and governors to discuss strategy.\r\n\r\nYour plan was simple but cunning: not to let Svyatopolk gather his forces in one place. You decided to act quickly, striking at his positions before he had strengthened his ranks."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Перед походом ти влаштував урочистий молебень, щоб попросити благословення Богів на цю справедливу війну. Народ зібрався навколо, молячись за перемогу. Атмосфера в твоєму війську була сповнена рішучості, адже кожен знав, що ти ведеш їх до боротьби за правду.\r\n\r\nТи також відправив гінців до сусідніх племен, щоб домовитися про нейтралітет або навіть отримати допомогу. Твоя дипломатія мала успіх – більшість вирішила не втручатися, а дехто навіть надіслав підкріплення.",
                                            TextEng = "Before the campaign, you held a solemn prayer service to ask the gods for their blessing on this just war. The people gathered around you, praying for victory. The atmosphere in your army was full of determination, for everyone knew that you were leading them to fight for what was right.\r\n\r\nYou also sent messengers to neighboring tribes to negotiate neutrality or even to obtain aid. Your diplomacy was successful - most decided not to interfere, and some even sent reinforcements."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Альта",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 20000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 43
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Yaroslav"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "Svyatopolk"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 29,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після вирішальної битви між Ярославом Мудрим та Святополком Окаянним доля Русі вкотре хитнулася, та цього разу — остаточно в бік порядку, а не смути. Кров, пролита під Лубнем, де війська Ярослава зійшлися з чисельно потужнішими силами Святополка та його союзника Болеслава Хороброго, не була даремною.",
                                            TextEng = "After the decisive battle between Yaroslav the Wise and Svyatopolk the Cursed, the fate of Rus' swung once again, but this time definitively towards order rather than turmoil. The blood shed at Lubny, where Yaroslav's troops clashed with the numerically superior forces of Svyatopolk and his ally Boleslav the Brave, was not in vain."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Після поразки, Святополк, відкинутий і своїми, і чужими, втік на захід. Зі свідчень літописців і пізніших хроністів, відомо, що він намагався зібрати залишки своєї влади, проте марно. Поляки, які ще вчора стояли з ним пліч-о-пліч, більше не бачили в ньому корисного союзника.",
                                            TextEng = "After the defeat, Svyatopolk, rejected by both his own and foreign people, fled to the west. From the testimonies of chroniclers and later chroniclers, it is known that he tried to gather the remnants of his power, but in vain. The Poles, who had stood with him shoulder to shoulder yesterday, no longer saw him as a useful ally."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "У 1019 році, Святополк помер у вигнанні — за однією з версій, у Чехії, за іншою — в межах Польщі. Народ і князі прозвали його Окаянним — не стільки за зраду братові, як за зраду самій Русі.",
                                            TextEng = "In 1019, Svyatopolk died in exile — according to one version, in Bohemia, according to another — within Poland. The people and princes nicknamed him the Accursed — not so much for betraying his brother, but for betraying Rus itself."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Ярослав, утвердившись у Києві, нарешті став єдиним володарем Руської землі. Битва завершила тривалу усобицю, яка точилася після смерті Володимира Великого. Він почав активно розбудовувати державу, укріплюючи не тільки її військову, а й духовну основу. На зміну братовбивчому безглуздю прийшов порядок.",
                                            TextEng = "Yaroslav, having established himself in Kiev, finally became the sole ruler of the Russian land. The battle ended a long feud that had been going on since the death of Vladimir the Great. He began to actively build the state, strengthening not only its military but also its spiritual foundation. Order replaced the fratricidal madness."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "З Києва Ярослав правив уже не просто як князь, а як будівничий державності. Він відновив зв’язки з Константинополем, затвердив нові князівства для синів і розпочав розробку першого письмового зводу законів — «Руської правди».",
                                            TextEng = "From Kyiv, Yaroslav ruled not just as a prince, but as a builder of statehood. He restored ties with Constantinople, established new principalities for his sons, and began drafting the first written code of laws, the Rus' Pravda."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Після остаточної перемоги над Святополком Окаянним та його смертю в 1019 році, перед Ярославом Мудрим відкрилися двері до творення нової доби Русі. Київ упокорився, а воля Ярослава стала єдиним законом для розбурханої держави. Але спокій не прийшов одразу. Мусив він наводити лад після руйнацій, гасити залишки повстань, укріплювати кордони і формувати нову внутрішню опору влади.",
                                            TextEng = "After the final victory over Svyatopolk the Cursed and his death in 1019, the door to the creation of a new era of Rus' opened before Yaroslav the Wise. Kyiv was subdued, and Yaroslav's will became the only law for the turbulent state. But peace did not come immediately. He had to restore order after the destruction, quell the remnants of the uprisings, strengthen the borders and form a new internal support for power."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "На заході ще дихала Польща, що недавно сунула рать під хоругвами Болеслава Хороброго. Ярослав не поспішав помститися — уклав мир, одружився з дочкою скандинавського конунга Інгігердою (Іриною), і тим самим залучив на свій бік варязьку підтримку. У 1020-х він розпочав укріплення міст і будівництво фортець по рубежах, зокрема на півдні — де кочовики знову заглядали в українські степи.",
                                            TextEng = "In the west, Poland was still breathing, having recently sent an army under the banners of Bolesław the Brave. Yaroslav was in no hurry to take revenge - he made peace, married the daughter of the Scandinavian king Ingigerda (Irina), and thereby attracted Varangian support to his side. In the 1020s, he began to strengthen cities and build fortresses along the borders, particularly in the south - where nomads again looked into the Ukrainian steppes."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "У ці роки закладається славетна Софія Київська, велетенська кам'яна святиня, гідна імперських міст. Це був не лише жест віри, а й політична заява — Київ став духовним і культурним центром на рівні Константинополя.\r\n\r\nТак само Ярослав закріплює внутрішню правову систему. «Руська Правда», складена саме в цей період, стала наріжним каменем управління державою. Князь, який раніше ходив у бойовому плащі, тепер одягнув мантію законодавця.",
                                            TextEng = "During these years, the glorious St. Sophia of Kiev was laid, a gigantic stone shrine worthy of imperial cities. It was not only a gesture of faith, but also a political statement - Kiev became a spiritual and cultural center on the level of Constantinople.\r\n\r\nYaroslav also consolidated the internal legal system. \"Russkaya Pravda\", compiled during this period, became the cornerstone of state governance. The prince, who had previously walked in a battle cloak, now donned the mantle of a legislator."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Водночас він не забував і про зовнішню політику. Династичні шлюби з Францією, Норвегією, Угорщиною, Польщею і Візантією перетворили Русь на поважного гравця в європейському клубі монархій. Саме тому історики й прозвали Ярослава — Тестем Європи.",
                                            TextEng = "At the same time, he did not forget about foreign policy. Dynastic marriages with France, Norway, Hungary, Poland, and Byzantium turned Russia into a respectable player in the European club of monarchies. That is why historians nicknamed Yaroslav the Father-in-Law of Europe."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "Проте війна з печенігами ще чекала свого часу. На півдні Русь готувалася до великої битви, яку Ярослав виграє в 1036 році, остаточно знищивши загрозу кочових набігів. Але це — вже інший розділ.",
                                            TextEng = "However, the war with the Pechenegs was still waiting for its time. In the south, Rus was preparing for a great battle, which Yaroslav would win in 1036, finally destroying the threat of nomadic raids. But that is another chapter."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "1036",
                                        Description = "Княже, ти відчував, як з кожною зимою степ дихає ближче. Печеніги більше не просто кочували — вони нишпорили біля наших рубежів, спостерігали, шукали слабке місце, щілину в захисті. Ми знали: їхній напад — лише питання часу. І тому ти не чекав, коли ворог ударить першим.",
                                        DescriptionEng = "Prince, you felt how the steppe breathed closer with each winter. The Pechenegs were no longer just wandering - they were prowling around our borders, observing, looking for a weak spot, a gap in the defense. We knew: their attack was only a matter of time. And that's why you didn't wait for the enemy to strike first.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 10
                                            },
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 30,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Ти наказав зміцнити південні укріплення — у Києві, Переяславі, Вишгороді, по лівому березі Дніпра. Ми вирізали нові зрубні вежі, насипали оборонні вали, ставили варту, що не знала сну. Селяни і ремісники вчилися володіти списом, а княжі вої — тепер не лише дружинники, а й міцно озброєні ратники зі всієї округи — пройшли численні збори.",
                                            TextEng = "You ordered the southern fortifications to be strengthened - in Kyiv, Pereyaslav, Vyshgorod, on the left bank of the Dnieper. We carved new log towers, built defensive ramparts, and posted a guard that knew no sleep. Peasants and artisans learned to wield a spear, and the princely warriors - now not only druzhinniks, but also heavily armed warriors from the entire district - underwent numerous gatherings."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "І водночас ти збирав союз. Посли рушали в Новгород, Ростов, Смоленськ, Чернігів — бо ми знали: лише єдністю зможемо втримати землю. Ти підкупив час, заключивши короткі перемир’я з литовськими племенами й поляками, аби захід був спокійним, поки південь готується до бурі.",
                                            TextEng = "And at the same time you were gathering an alliance. Ambassadors were setting off to Novgorod, Rostov, Smolensk, Chernigov — because we knew: only through unity can we hold the land. You bought time by concluding short truces with the Lithuanian tribes and Poles, so that the west would be calm while the south prepared for the storm."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "На твоєму боці вже були не лише мечі, а й молитви. Митрополити й ігумени молились за перемогу, церкви зміцнювали дух. І над усім тим — твоє слово, княже: тверде, як криця, і ясне, як день.\r\n\r\nТи не йшов на битву із поспіхом. Ти чекав, поки ворог сам прийде — але був готовий зустріти його не як жертва, а як той, хто давно вирив для нього пастку.",
                                            TextEng = "On your side were already not only swords, but also prayers. Metropolitans and abbots prayed for victory, churches strengthened their spirit. And above all that — your word, prince: firm as clay, and clear as day.\r\n\r\nYou did not go to battle in a hurry. You waited for the enemy to come himself — but you were ready to meet him not as a victim, but as one who had long ago dug a trap for him."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Велика битва наближалася. І все на Русі дихало очікуванням — не страху, а впевненості, що князь Ярослав — не лише син Володимира, а й меч Господній, яким буде відсічено ланцюг кочового терору.",
                                            TextEng = "The great battle was approaching. And everything in Russia breathed with expectation — not fear, but confidence that Prince Yaroslav was not only the son of Vladimir, but also the sword of the Lord, which would cut the chain of nomadic terror."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Ранок тієї осені 1036 року видався похмурим, але спокійним. Над Дніпром повис туман, ніби сама земля затамувала подих. Київ ще спав, але ми — ні. Наші розвідники поверталися з тривожними звістками: печенізькі орди, наче чорна хмара, сунули до міста з південного степу. Не грабіжницький наліт — а справжній наступ, об’єднаний, великий. Їх було не менше ніж сорок тисяч, з усієї орди. Йшли з таборами, возами, зі старими та жінками — значить, не повертатися з Києва вони не збирались.",
                                            TextEng = "The morning of that autumn of 1036 seemed gloomy, but calm. A fog hung over the Dnieper, as if the earth itself had held its breath. Kyiv was still asleep, but we were not. Our scouts were returning with alarming news: the Pecheneg hordes, like a black cloud, were advancing on the city from the southern steppe. Not a raiding raid — but a real attack, united, large. There were no less than forty thousand of them, from the entire horde. They were coming with camps, carts, with old men and women — so they were not going to not return from Kyiv."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Ти, княже Ярославе, був у Новгороді — але не гаяв ані години. Як лиш почув, що Київ під загрозою, зібрав усі свої сили та рішуче рушив до столиці. І поки ти скакав крізь осінній дощ, ми в Києві вже готувались до бою. Вся княжа дружина, полки із Вишгорода, Переяслава, навіть кілька сотень новгородських стрільців, що встигли прибути раніше, зосередились біля Лядських воріт — саме туди мав лягти головний удар ворога.",
                                            TextEng = "You, Prince Yaroslav, were in Novgorod — but you didn’t waste a single hour. As soon as you heard that Kyiv was under threat, you gathered all your forces and resolutely moved towards the capital. And while you were galloping through the autumn rain, we in Kyiv were already preparing for battle. The entire princely squad, regiments from Vyshgorod, Pereyaslav, even a few hundred Novgorod riflemen who had arrived earlier, concentrated near the Lyadsky Gate — that was where the enemy’s main blow was to be struck."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "На світанку наші дозори повідомили: печеніги вже таборують під самим Києвом, розбивши стійбища у трьох милях на південь. Їхній табір був широкий і неорганізований, вони не чекали, що Русь зуміє виступити так швидко. Але ми вже були готові.\r\n\r\nІ тоді з’явився ти, княже — з півночі, з полками, що зміцнили наші ряди. Бойовий дух піднявся, мов полум’я. Воїн воїну передавав: «Князь із нами!» — і це додавало більше, ніж меч у руці.",
                                            TextEng = "At dawn, our patrols reported: the Pechenegs were already encamped near Kiev itself, having set up camp three miles to the south. Their camp was wide and disorganized, they did not expect that Russia would be able to advance so quickly. But we were already ready.\r\n\r\nAnd then you appeared, prince - from the north, with regiments that strengthened our ranks. The fighting spirit rose like a flame. Warrior to warrior passed on: \"The prince is with us!\" - and this added more than a sword in hand."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Надвечір, коли ворог ще не встиг укріпитись, ти віддав наказ готувати лаву. І ми пішли — не в оборону, а в наступ. Бо земля Русі — то не здобич для степу. І наш клич, змішаний із гортанним риком печенігів, вперше зійшовся в єдиному місці: на полі великої битви, що вирішить долю цілого століття.\r\n\r\nМечі були витягнуті. І поле готувалось до кривавого жнив’я.",
                                            TextEng = "In the evening, when the enemy had not yet had time to strengthen, you gave the order to prepare the line. And we went - not to the defense, but to the offensive. For the land of Russia is not prey for the steppe. And our cry, mixed with the guttural roar of the Pechenegs, for the first time converged in one place: on the field of the great battle, which would decide the fate of an entire century.\r\n\r\nSwords were drawn. And the field was prepared for a bloody harvest."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Київ",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 38000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 80
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Yaroslav"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 31,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Коли пил битви осів, а печенізькі тіла вкрили поле перед Лядськими воротами — ми зрозуміли: це не просто перемога. Це була відплата. Печенізький табір був розбитий ущент, їхні сили розсіяні, вожді загинули або потрапили в полон. Ворог, що десятиліттями тероризував південні рубежі Русі, більше ніколи не насмілиться наблизитись до Києва. Серед людей пішло слово, що сам Бог благословив цю перемогу, і ми не відступили перед навалою, бо стояли на праведній землі.",
                                            TextEng = "When the dust of the battle settled and the Pecheneg bodies covered the field in front of the Lyadsky Gate, we understood: this was not just a victory. This was retribution. The Pecheneg camp was completely destroyed, their forces scattered, their leaders killed or captured. The enemy, who had terrorized the southern borders of Rus for decades, would never again dare to approach Kyiv. Word spread among the people that God himself had blessed this victory, and we did not retreat before the invasion, because we stood on righteous ground."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Ти, княже, зібрав старійшин, дружинників і духовенство — і на полі битви постановив: буде тут святиня. Бо там, де руська кров змилась дощем із чорної землі, має вирости храм, щоб звеличити Того, хто дарував перемогу. Так було закладено Софію Київську — не просто церкву, а символ слави, мудрості й вічності держави.",
                                            TextEng = "You, prince, gathered the elders, warriors, and clergy — and on the battlefield you decreed: there will be a shrine here. For where the Russian blood was washed away by rain from the black earth, a temple must grow to glorify the One who granted victory. Thus was founded St. Sophia of Kiev — not just a church, but a symbol of glory, wisdom, and eternity of the state."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Після перемоги ти укріпив кордони, звів оборонні споруди, поставив дозори вздовж степу. На південь вирушили посланці — до печенігів, що залишилися. Одним — попередження, іншим — слово миру. Бо Русь уже не була беззахисною.\r\n\r\nМісто Київ святкувало. Купці знову рушили шляхом «із варяг у греки», без страху. Жінки та діти не плакали при згадці про степ. І в кожній хаті, в кожному домі запанував спокій — той, що здобувається лише кров’ю та залізом.",
                                            TextEng = "After the victory, you strengthened the borders, built defensive structures, and set up patrols along the steppe. Envoys set off south to the remaining Pechenegs. One with a warning, the other with a word of peace. For Rus was no longer defenseless.\r\n\r\nThe city of Kyiv celebrated. Merchants once again set off on the path “from the Varangians to the Greeks,” without fear. Women and children did not cry at the mention of the steppe. And in every hut, in every house, peace reigned—the kind that can only be won with blood and iron."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "А ім’я твоє, княже, — Ярослав Мудрий — відтоді стало не лише титулом, а визначенням цілої епохи. І ми знали: попереду нові справи, нові закони, нові храми. Але вже не у тіні страху, а в світлі перемоги.",
                                            TextEng = "And your name, prince, Yaroslav the Wise, has since become not just a title, but the definition of an entire era. And we knew: new deeds, new laws, new temples lay ahead. But no longer in the shadow of fear, but in the light of victory."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Твоє князювання, Ярославе, стало символом початку правового порядку на Русі. Ти не лише завоював серця своїх підданих, а й започаткував реформу у судочинстві. «Руська правда» стала першим важливим документом, що впорядковував суспільне життя. Вона визначала правила для всіх — від найвищих до найнижчих. Це був не просто юридичний кодекс, а й фундамент для майбутніх поколінь, які за ним жили, працювали та захищали землю. Від тебе, княже, Русь отримала впорядковане суспільство, де не було місця свавіллю.",
                                            TextEng = "Your reign, Yaroslav, became a symbol of the beginning of the legal order in Russia. You not only won the hearts of your subjects, but also initiated a reform in the judiciary. “Russkaya Pravda” became the first important document that regulated public life. It defined the rules for everyone — from the highest to the lowest. It was not just a legal code, but also the foundation for future generations who lived, worked and protected the land according to it. From you, prince, Rus received an ordered society, where there was no place for arbitrariness."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Ти, Ярославе, сам був прикладом мудрості та віри, яка пронизувала твоє правління. Від початку твого правління Київ перетворювався на центр величі. Один з найбільших символів твоєї влади — це Софійський собор, велетенська святиня, яка була збудована як утілення не лише релігійної, але й культурної сили Русі. Вона стала центром християнського життя, тут почали діяти школи та бібліотеки, що дозволяли розвивати освіченість серед народу. Ти сам створював умови для розвитку культури, запровадивши скрипторії та підтримавши діяльність книжників.",
                                            TextEng = "You, Yaroslav, were yourself an example of the wisdom and faith that permeated your reign. From the beginning of your reign, Kyiv was transformed into a center of greatness. One of the greatest symbols of your power is St. Sophia Cathedral, a gigantic shrine that was built as the embodiment of not only the religious, but also the cultural power of Rus. It became the center of Christian life, schools and libraries began to operate here, which allowed the development of education among the people. You yourself created the conditions for the development of culture, introducing scriptoria and supporting the activities of scribes."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Важливим аспектом твого правління, княже, стала дипломатія. Ти, здається, обвів увесь континент, використовуючи не лише меч, але й мирний шлях, укладаючи союзи через шлюби. Донька Анна стала королевою Франції, і це стало частиною твоєї стратегічної політики, яка зміцнила твої позиції серед європейських правителів. Завдяки цьому ти забезпечив Русь великим визнанням на міжнародній арені. Кожен шлюб зміцнював зв’язки з іншими державами, і цими зв’язками ти намагався протистояти можливим загрозам ззовні.",
                                            TextEng = "An important aspect of your reign, prince, was diplomacy. You seem to have circled the entire continent, using not only the sword, but also the peaceful path, making alliances through marriage. Your daughter Anna became Queen of France, and this became part of your strategic policy, which strengthened your position among European rulers. Thanks to this, you provided Russia with great recognition on the international stage. Each marriage strengthened ties with other states, and with these ties you tried to resist possible threats from the outside."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Останні роки правління Ярослава Мудрого були часом стабільності для Русі, але й періодом, що позначався новими викликами. Протягом цього часу, князь вже не так активно розширював свої землі, як у попередні роки, але зосередився на зміцненні того, що він здобув раніше. Він продовжував утримувати союз із Західною Європою через шлюби своїх дітей і навіть намагався зміцнити християнство в Русі, через будівництво нових церков і сприяння розвитку церковної організації.",
                                            TextEng = "The last years of Yaroslav the Wise's reign were a time of stability for Rus', but also a period marked by new challenges. During this time, the prince was no longer as active in expanding his lands as in previous years, but focused on consolidating what he had previously gained. He continued to maintain an alliance with Western Europe through the marriages of his children and even tried to strengthen Christianity in Rus', by building new churches and promoting the development of church organization."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Однією з важливих подій цього періоду стало те, що Ярослав все більше переймався питаннями внутрішнього управління, встановлюючи певний баланс між старшими князями. Проте після його смерті, коли розпочалася боротьба між синами за владу, цей баланс розпався.",
                                            TextEng = "One of the important events of this period was that Yaroslav became increasingly concerned with internal governance, establishing a certain balance between the senior princes. However, after his death, when the struggle for power began between his sons, this balance collapsed."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "У 1054 році Ярослав передав владу своїм синам: Ізяславу, Святославу і Всеволоду. Розподіл земель між синами був важливим кроком для уникнення внутрішніх конфліктів, але цей розподіл згодом став причиною боротьби за владу між князями. Це стало першою ознакою того, що Русь після його смерті зіткнеться з новими труднощами у підтримці єдності держави.",
                                            TextEng = "In 1054, Yaroslav passed power to his sons: Izyaslav, Svyatoslav and Vsevolod. The division of lands between the sons was an important step in avoiding internal conflicts, but this division later became the cause of the struggle for power between the princes. This was the first sign that after his death, Rus would face new difficulties in maintaining the unity of the state."
                                        },
                                        new Content()
                                        {
                                            Id = 10,
                                            Text = "Після того, як Ярослав Мудрий передав своїм синам керування великими частинами держави, настав час, коли велич і єдність Русі почали поступово руйнуватися. Він розумів, що його спадщина стане перевіркою на здатність зберігати єдність у межах величезної держави.",
                                            TextEng = "After Yaroslav the Wise handed over control of large parts of the state to his sons, the time came when the greatness and unity of Rus' began to gradually crumble. He understood that his legacy would be a test of his ability to maintain unity within the borders of a vast state."
                                        },
                                        new Content()
                                        {
                                            Id = 11,
                                            Text = "Після його смерті в 1054 році, Русь розділилась між його синами, і це стало початком періоду, відомого як період міжусобиць. Ті сини, які отримали частини держави, почали боротися за ще більшу владу, київський престол став об’єктом боротьби.",
                                            TextEng = "After his death in 1054, Rus' was divided among his sons, and this marked the beginning of a period known as the Period of Strife. Those sons who received parts of the state began to fight for even greater power, with the Kievan throne becoming the object of struggle."
                                        },
                                        new Content()
                                        {
                                            Id = 12,
                                            Text = "Ізяслав Ярославич, старший син Ярослава, отримав Київ. Він був обраний для того, щоб правити всією Руссю, але не зміг утримати владу без боротьби з братами. Боротьба між братами за князівства на заході та сході Русі стала звичайним явищем, що призвело до численних конфліктів. Ізяслав, незважаючи на спроби об'єднати державу, зіткнувся з великими труднощами.",
                                            TextEng = "Izyaslav Yaroslavich, the eldest son of Yaroslav, received Kiev. He was chosen to rule all of Rus', but could not hold on to power without a struggle with his brothers. The struggle between the brothers for the principalities in the west and east of Rus' became a common occurrence, leading to numerous conflicts. Izyaslav, despite his attempts to unite the state, faced great difficulties."
                                        },
                                        new Content()
                                        {
                                            Id = 13,
                                            Text = "Святослав Ярославич, князь Чернігова, прагнув зміцнити свій вплив і навіть намагався зібрати сили для боротьби за Київ. Внаслідок цього було кілька серйозних битв між синами Ярослава, і між ними розпочалася боротьба за домінування на різних територіях, що також вплинуло на зовнішні стосунки Русі.",
                                            TextEng = "Svyatoslav Yaroslavich, Prince of Chernigov, sought to strengthen his influence and even tried to gather forces to fight for Kiev. As a result, there were several serious battles between Yaroslav's sons, and a struggle began between them for dominance in various territories, which also affected the foreign relations of Rus."
                                        },
                                        new Content()
                                        {
                                            Id = 14,
                                            Text = "Не менш важливу роль у цих внутрішніх конфліктах відігравав Володимир Мономах, який згодом зумів стабілізувати ситуацію в державі. Однак навіть за його правління Русь лишалась у постійних розбратів і складнощах.",
                                            TextEng = "An equally important role in these internal conflicts was played by Vladimir Monomakh, who later managed to stabilize the situation in the state. However, even during his reign, Rus remained in constant discord and difficulties."
                                        },
                                        new Content()
                                        {
                                            Id = 15,
                                            Text = "Розподіл територій, постійні усобиці, боротьба за престол призвели до ослаблення єдності Русі, що стало однією з причин її подальших труднощів у боротьбі з зовнішніми ворогами, такими як половці і монголи.",
                                            TextEng = "The division of territories, constant feuds, and the struggle for the throne led to the weakening of the unity of Rus', which became one of the reasons for its subsequent difficulties in the fight against external enemies, such as the Polovtsy and Mongols."
                                        },
                                        new Content()
                                        {
                                            Id = 16,
                                            Text = "Врешті-решт, ці внутрішні міжусобиці стали одним із основних факторів, які призвели до падіння могутності Київської Русі, ослаблення центральної влади і фактичного поділу держави на дрібніші князівства.",
                                            TextEng = "Ultimately, these internal strife became one of the main factors that led to the decline of the power of Kievan Rus, the weakening of central power, and the de facto division of the state into smaller principalities."
                                        },
                                        new Content()
                                        {
                                            Id = 17,
                                            Text = "І минали роки після смерті Ярослава Мудрого, а землі Русі ставали дедалі розділенішими. Права старшого на престол Київський — те правило, що мало б тримати державу в єдності, обернулося тягарем і джерелом постійних усобиць.",
                                            TextEng = "And as the years passed after the death of Yaroslav the Wise, the lands of Rus became increasingly divided. The right of the eldest to the throne of Kiev, the rule that was supposed to keep the state united, turned into a burden and a source of constant strife."
                                        },
                                        new Content()
                                        {
                                            Id = 18,
                                            Text = "Ізяслав Ярославич, що спочатку успадкував Київ, не зміг утримати його у своїх руках надовго. Проти нього виступили його ж брати — Святослав і Всеволод. Вони, вбачаючи слабкість Ізяслава, змовились і вигнали його з Києва. Ізяслав шукав підтримки на заході, навіть звернувся по допомогу до польського короля Болеслава II Сміливого. За допомогою польських військ Ізяслав повернув собі владу, але ненадовго: невдовзі його знову вигнали, і Київська держава знову затрусилася від братовбивчої боротьби.",
                                            TextEng = "Izyaslav Yaroslavich, who initially inherited Kyiv, was unable to hold it in his hands for long. His own brothers, Svyatoslav and Vsevolod, opposed him. Seeing Izyaslav's weakness, they conspired and expelled him from Kyiv. Izyaslav sought support in the West, even turning to the Polish king Boleslav II the Bold for help. With the help of Polish troops, Izyaslav regained power, but not for long: he was soon expelled again, and the Kyiv state was once again shaken by fratricidal strife."
                                        },
                                        new Content()
                                        {
                                            Id = 19,
                                            Text = "Святослав Ярославич зайняв Київ, зміцнившись на троні, проте смерть не забарилася — і після його загибелі Всеволод Ярославич перебрав владу до своїх рук. Саме він тримав Київ у час, коли Русь уже розривали суперечності між різними князями, а землі почали жити власним життям.",
                                            TextEng = "Svyatoslav Yaroslavich took Kyiv, having consolidated his position on the throne, but death was not long in coming, and after his death, Vsevolod Yaroslavich took power into his own hands. It was he who held Kyiv at a time when Rus was already torn apart by conflicts between various princes, and the lands began to live their own lives."
                                        },
                                        new Content()
                                        {
                                            Id = 20,
                                            Text = "А на південних степах наростала нова загроза: половці, сильні і численні, щороку глибше проникали в руські землі, розоряючи міста й села. Київ уже не міг один стримати натиск — князі мусили домовлятися, виступати разом, але сварки між ними раз по раз ламали кожен союз.",
                                            TextEng = "And in the southern steppes a new threat was growing: the Polovtsy, strong and numerous, penetrated deeper into the Rus' lands every year, ravaging cities and villages. Kyiv could no longer hold back the onslaught alone - the princes had to come to an agreement and act together, but quarrels between them repeatedly broke each alliance."
                                        },
                                        new Content()
                                        {
                                            Id = 21,
                                            Text = "Всеволод Ярославич, у старості вже немічний, намагався тримати державу бодай у зовнішньому спокої. Та коли його не стало, на полі брані знову зустрілися руські князі. І лише народжений із кращого кореня — син Всеволода, Володимир Мономах, зміг хоч на деякий час стримати падіння, зібрати князів, приборкати гордість та ворожнечу.",
                                            TextEng = "Vsevolod Yaroslavich, already weak in old age, tried to keep the state at least in external peace. But when he was gone, the Russian princes met again on the battlefield. And only Vsevolod's son, Vladimir Monomakh, who was born of a better lineage, was able to at least for a while restrain the decline, gather the princes, and curb pride and enmity."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "1113",
                                        Description = "Та це вже буде новий час, нова доба. Доба, коли Русь, зранена і стомлена міжусобицями, ще раз підніметься для останнього великого злету перед майбутніми випробуваннями.",
                                        DescriptionEng = "But this will be a new time, a new era. An era when Russia, wounded and tired of internecine strife, will rise once again for the last great takeoff before the future trials.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = -500
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = -20
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 32,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Коли Володимир Мономах ступив на київські пороги, Русь була, мов поле після бурі: міста понівечені, села знесилені, люди озлоблені. Половці безкарно нишпорили степами і межами, князі чварилися за кожен клаптик землі, а купці оминали Київ, як розбитий міст.\r\n\r\nІ тоді Володимир, не гаючи часу, взявся до діла, ніби вправний коваль, що лагодить зламаний меч.",
                                            TextEng = "When Volodymur Monomakh stepped on the threshold of Kiev, Rus was like a field after a storm: cities were devastated, villages were exhausted, people were embittered. Polovtsians roamed the steppes and borders with impunity, princes were fighting for every piece of land, and merchants bypassed Kiev like a broken bridge.\r\n\r\nAnd then Vladimir, without wasting time, got down to business, like a skilled blacksmith mending a broken sword."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Першим ділом він скликав військо з усього князівства. Він не кликав у походи заради слави чи здобичі, він кликав заради миру. Гнали половців без відпочинку: одних змусили схилити коліна і скласти зброю, інших — відігнали далеко за степові межі. Було здійснено низку походів — не в єдину битву, а в довгу війну на виснаження, де меч і розум ішли поряд. Він не дозволяв ворогу отямитися, не давав йому часу знову зібрати силу.",
                                            TextEng = "The first thing he did was to call an army from all over the principality. He did not call for campaigns for the sake of glory or booty, he called for peace. The Polovtsians were driven without rest: some were forced to bend their knees and lay down their weapons, others were driven far beyond the steppe borders. A series of campaigns were carried out - not in a single battle, but in a long war of attrition, where the sword and the mind went hand in hand. He did not allow the enemy to come to his senses, did not give him time to gather strength again."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Одночасно з мечем у руці Мономах тримав і перо законодавця. Він видав Статут, у якому захистив найслабших: заборонив лихварям забирати боржників у рабство за дрібні борги, обмежив розміри відсотків, впорядкував судочинство. Народ уперше за довгі роки відчув, що закон є не лише батогом сильного, а й щитом для скривдженого.",
                                            TextEng = "At the same time as the sword in his hand, Monomakh also held the pen of a legislator. He issued a Statute in which he protected the weakest: he forbade usurers from taking debtors into slavery for small debts, limited the amount of interest, and streamlined the judicial process. For the first time in many years, the people felt that the law was not only a whip for the strong, but also a shield for the wronged."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Володимир не сидів у палатах — він об'їжджав міста й волості, відновлював укріплення, будував нові фортеці. Київ знову став перлиною серед руських земель, а Чернігів, Смоленськ, Переяславль за його волею підвелися після руїни. Купці повернулися на торжища, ремісники розпалили кузні, землероби знову орали родючі поля.",
                                            TextEng = "Vladimir did not sit in the chambers - he traveled around the cities and volosts, restored fortifications, built new fortresses. Kyiv again became a pearl among the Rus' lands, and Chernihiv, Smolensk, Pereyaslavl rose from their ruins by his will. Merchants returned to the marketplaces, artisans fired up forges, farmers plowed fertile fields again."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Description = "Старість нахиляла його голову, але не ламала духу. Володимир до останнього дня тримав державу міцно, як батько тримає втомлене, але улюблене дитя. Його мудрість стала тим муром, об який розбивалися і половці, і свавілля князів, і жадоба боярства.\r\n\r\nТак минали роки, і вся Русь знала: поки є Мономах, є сила, є порядок, є надія. Але час невблаганний навіть до найкращих синів землі...\r\n\r\nПопереду чекала нова доба, і чи буде вона світлою — залежало вже не тільки від меча, а й від духу тих, хто залишиться після нього.",
                                        DescriptionEng = "Old age bowed his head, but did not break his spirit. Vladimir held the state firmly until the last day, as a father holds a tired but beloved child. His wisdom became the wall against which the Polovtsy, the arbitrariness of the princes, and the greed of the boyars were smashed.\r\n\r\nThus the years passed, and all of Russia knew: as long as Monomakh exists, there is strength, there is order, there is hope. But time is inexorable even to the best sons of the earth...\r\n\r\nA new era awaited ahead, and whether it would be bright depended not only on the sword, but also on the spirit of those who would remain after him.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 200
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 20
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 33,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Далі... Далі настав час, коли Мономах, відчувши наближення останнього шляху, скликав усіх своїх дітей, князів і бояр до себе. Його голос був уже не таким гучним, як колись на полі бою, але кожне слово, кожен його погляд важили більше за меч і золото.",
                                            TextEng = "Then... Then came the time when Monomakh, sensing the approach of his final journey, summoned all his children, princes, and boyars to him. His voice was no longer as loud as it had once been on the battlefield, but every word, every look of his weighed more than a sword and gold."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Він заповідав єдність. Він благав синів не роздирати землю, не ламати те, що будував він кров'ю і потом. Говорив їм, як батько перед смертю ділить між дітьми свою мудрість: «Будьте, як браття однієї плоті, а не вовки, що роздирають один одного». Він лишив їм не скарби, а своє слово — «Повчання», де виклав усе, що сам пізнав за життя: як боротися з ворогами, як тримати віру і як не дати владі отруїти серце.",
                                            TextEng = "He enjoined unity. He begged his sons not to tear up the earth, not to break what he had built with blood and sweat. He told them, as a father shares his wisdom among his children before his death: \"Be like brothers of one flesh, and not wolves tearing each other apart.\" He left them not treasures, but his word - \"Teachings\", where he laid out everything he had learned during his life: how to fight enemies, how to keep faith and how not to let power poison the heart."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "У 1125 році великий Володимир Мономах віддав свою душу Богові. Київ стояв у скорботі, і вся Русь, від синього Дніпра до суворих північних лісів, оплакала того, хто був їй справжнім батьком.\r\n\r\nТа не встигла земля вкрити його могилу, як над державою знову згущалися хмари. Його син, Мстислав Володимирович, який отримав престол, був гідним сином свого батька — сильним, розважливим, рішучим. Але кров княжа не завжди слухає волю померлого володаря.",
                                            TextEng = "In 1125, the great Vladimir Monomakh gave up his soul to God. Kyiv stood in mourning, and all of Russia, from the blue Dnieper to the harsh northern forests, mourned the one who was her true father.\r\n\r\nBut the earth had no time to cover his grave when clouds again gathered over the state. His son, Mstislav Vladimirovich, who received the throne, was a worthy son of his father - strong, prudent, decisive. But the prince's blood does not always obey the will of the deceased ruler."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Удільні князі знову почали хитатися, мов зграя вовків, кожен тягнув ковдру на себе. Чвари поволі, наче іржа, точили єдність. Половці, відчувши слабкість, знову почали турбувати прикордонні міста. Київ утримувався, та скрізь на окраїнах уже тліли іскри нових смут.",
                                            TextEng = "The princes of the Udil region began to totter again, like a pack of wolves, each pulling a blanket over himself. The quarrels slowly, like rust, were wearing away unity. The Polovtsians, sensing weakness, began to trouble the border towns again. Kyiv held out, but everywhere on the outskirts sparks of new unrest were already smoldering."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Мстислав, як міг, стримував розпад. Він продовжував політику батька, карав заколотників, збирав князів на з’їзди, укладав мир із Візантією, намагався тримати торгівлю й укріплювати кордони. Він розумів, що без спільного стягу Русь розпадеться на шматки, кожен із яких буде легкою здобиччю для половців, угорців, литовців чи німецьких мечоносців.",
                                            TextEng = "Mstislav, as best he could, restrained the disintegration. He continued his father's policy, punished the rebels, gathered the princes for congresses, made peace with Byzantium, tried to maintain trade and strengthen the borders. He understood that without a common banner, Russia would fall into pieces, each of which would be easy prey for the Polovtsians, Hungarians, Lithuanians or German swordsmen."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Проте після його смерті у 1132 році Русь таки почала швидко хилитися до роздробленості. Київ залишався головою, але тіло держави вже тріщало по швах.\r\n\r\nНад землею, що недавно гордилася силою Мономаха, нависла тривожна тінь — тінь братовбивства і міжусобиць. Але ще жили ті, хто пам’ятав великого князя і його заповіт. І надія, хоч і слабка, ще жевріла, що прийде новий час і новий меч здійметься над Руссю.",
                                            TextEng = "However, after his death in 1132, Rus did begin to rapidly drift towards fragmentation. Kiev remained the head, but the body of the state was already cracking at the seams.\r\n\r\nOver the land, which had recently been proud of the power of Monomakh, an alarming shadow hung - the shadow of fratricide and civil strife. But there were still those who remembered the great prince and his testament. And hope, albeit weak, still flickered that a new time would come and a new sword would be raised over Rus."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "Далі — почалася доба, яку ми, озираючись, називаємо Руїною Русі. Після смерті Мстислава Великого розпочалося те, що стримував Володимир Мономах усім своїм життям: брат пішов на брата, син — проти батька, князь — проти князя.",
                                            TextEng = "Then began the era that we, looking back, call the Ruin of Rus. After the death of Mstislav the Great, what Vladimir Monomakh had been holding back all his life began: brother turned against brother, son against father, prince against prince."
                                        },
                                        new Content()
                                        {
                                            Id = 7,
                                            Text = "Київ і далі залишався омріяною здобиччю: хто сідав на київський стіл — той наче одягав корону всієї Русі. Але сила його вже була не та. Кожен з удільних князів вважав себе самостійним володарем, кожен плекав свої амбіції, шукав підтримки серед половців, угорців, литовців, поляків. Русь, яка ще недавно грізно котила свої полки в далекі степи і тримала в покорі сусідні народи, тепер сама стала здобиччю власної жадібності.",
                                            TextEng = "Kyiv continued to be a coveted prey: whoever sat down at the Kyivan table was, as it were, wearing the crown of all of Russia. But its power was no longer the same. Each of the local princes considered himself an independent ruler, each cherished his own ambitions, sought support among the Polovtsians, Hungarians, Lithuanians, and Poles. Rus, which had recently menacingly rolled its regiments into the distant steppes and held neighboring peoples in subjection, now itself became a prey to its own greed."
                                        },
                                        new Content()
                                        {
                                            Id = 8,
                                            Text = "Київські князі змінювалися один за одним, наче листя восени з дерев падає. Хто силою, хто підступом, хто з волі народного віче — кожен хотів урвати свою частку влади. Боротьба не вщухала ні на день: угодовці і войовники, зрадники і патріоти — всі переплелися в єдиному кривавому танці за владу.",
                                            TextEng = "The Kiev princes changed one after another, like leaves falling from trees in autumn. Some by force, some by trickery, some by the will of the people's council - everyone wanted to snatch their share of power. The struggle did not subside for a day: compromisers and warriors, traitors and patriots - all intertwined in a single bloody dance for power."
                                        },
                                        new Content()
                                        {
                                            Id = 9,
                                            Text = "Північ піднімалася: могутніли Суздаль, Ростов, Переяславль. У ті землі ішли шукачі спокою і кращої долі, бо на півдні палали села й міста, князівські дружини й половці виривали один в одного землю і людей.",
                                            TextEng = "The north was rising: Suzdal, Rostov, and Pereyaslavl were growing in power. Seekers of peace and a better fate went to those lands, because in the south villages and cities were burning, princely retinues and Polovtsy were wresting land and people from each other."
                                        },
                                        new Content()
                                        {
                                            Id = 10,
                                            Text = "Половці, відчувши, що межа тримається лише на старій славі, стали нахабнішими. Вони вже не просто нападали — вони вимагали данину, втручалися у внутрішні справи князів, ставили свої умови.\r\n\r\nА Київ... Київ, велика мати руських міст, втратив колишню славу. Його багаті купці шукали безпечніших пристаней для своїх кораблів, його монастирі благали про мир у молитвах, його мечі ще блищали на сонці, але сили ставало все менше.",
                                            TextEng = "The Polovtsians, feeling that the limit was only on their old glory, became more impudent. They no longer simply attacked - they demanded tribute, interfered in the internal affairs of the princes, set their own conditions.\r\n\r\nAnd Kiev... Kiev, the great mother of Rus`s cities, lost its former glory. Its rich merchants sought safer harbors for their ships, its monasteries begged for peace in prayers, its swords still glittered in the sun, but their strength was becoming less and less."
                                        },
                                        new Content()
                                        {
                                            Id = 11,
                                            Text = "Та все ж таки пам’ять про колишню єдність жила. Жила в тих, хто ще не зрадив Русь ні золоту, ні мечу чужинців. Серед хаосу та зради ще часом здіймалися постаті князів, які мріяли об'єднати землю, знову підняти знамено великої держави.\r\n\r\nІ над усім цим стояло невидиме питання: хто буде тим, хто збере розпорошену Русь? Хто знову покладе меч до підніжжя Києва не для здобичі, а для служіння?",
                                            TextEng = "But still the memory of the former unity lived. It lived in those who had not yet betrayed Rus' to either gold or the sword of foreigners. Amidst the chaos and betrayal, figures of princes still occasionally rose, dreaming of uniting the land, of raising the banner of a great state again.\r\n\r\nAnd above all this stood an invisible question: who would be the one to gather the scattered Rus'? Who would once again lay the sword at the foot of Kyiv not for plunder, but for service?"
                                        },
                                        new Content()
                                        {
                                            Id = 12,
                                            Text = "Найбільший вплив на цих землях здобули князі Володимиро-Суздальського, Чернігівського та Переяславського князівств, які почали змагатися за контроль над Києвом. Оскільки Київ став менш важливим через ослаблення його політичної позиції, престиж і стабільність почали зміщуватися в інші князівства. Це посилювало тенденцію до розпаду єдиної Русі на окремі князівства.",
                                            TextEng = "The greatest influence in these lands was gained by the princes of the Vladimir-Suzdal, Chernigov, and Pereyaslav principalities, who began to compete for control of Kyiv. As Kyiv became less important due to the weakening of its political position, prestige and stability began to shift to other principalities. This strengthened the tendency for the disintegration of a unified Rus' into separate principalities."
                                        },
                                        new Content()
                                        {
                                            Id = 13,
                                            Text = "Також важливим чинником став вплив половців, які неодноразово здійснювали набіги на Русь у цей період. Їхні напади були постійною загрозою для князівств, що сприяло ще більшому ослабленню централізованої влади. Боротьба з половцями вимагала від князів воєнних зусиль, але часто не вистачало єдності між ними, що лише ускладнювало ситуацію.",
                                            TextEng = "Another important factor was the influence of the Polovtsy, who repeatedly raided Rus' during this period. Their attacks were a constant threat to the principalities, which contributed to the further weakening of centralized power. The fight against the Polovtsy required military efforts from the princes, but there was often a lack of unity between them, which only complicated the situation."
                                        },
                                        new Content()
                                        {
                                            Id = 14,
                                            Text = "Через цей період частих змін князів на престолі Київське князівство стало символом розколу і політичної нестабільності, яка поступово призвела до ще більшого дроблення Русі на різні князівства, які часто були в стані боротьби між собою.",
                                            TextEng = "Due to this period of frequent changes of princes on the throne, the Kievan Principality became a symbol of schism and political instability, which gradually led to the further fragmentation of Rus' into various principalities, which were often in a state of struggle with each other."
                                        },
                                        new Content()
                                        {
                                            Id = 15,
                                            Text = "Після періоду частих змін князів на троні Київського князівства ситуація стабілізувалася лише частково. В кінці XII — на початку XIII століття, після періоду боротьби між різними князями за контроль над Києвом, почав формуватися новий порядок. Найбільший вплив на території Русі отримав великий князь київський, котрий намагався зберегти єдність держави, хоч і вже не з таким сильним централізованим контролем.",
                                            TextEng = "After a period of frequent changes of princes on the throne of the Kievan principality, the situation stabilized only partially. At the end of the 12th - beginning of the 13th century, after a period of struggle between various princes for control over Kiev, a new order began to form. The greatest influence on the territory of Rus was received by the Grand Duke of Kiev, who tried to preserve the unity of the state, although no longer with such strong centralized control."
                                        },
                                        new Content()
                                        {
                                            Id = 16,
                                            Text = "У 1169 році відбулася значуща подія — Андрій Боголюбський, великий князь Володимиро-Суздальський, захопив Київ. Це означало фактичний кінець періоду домінування Києва як політичного і культурного центру Русі. Володимиро-Суздальське князівство стало одним із найбільших і потужних, і з того часу його роль почала посилюватися, а Київ — втрачати своє значення.",
                                            TextEng = "In 1169, a significant event occurred - Andrei Bogolyubsky, Grand Prince of Vladimir-Suzdal, captured Kyiv. This marked the actual end of the period of Kyiv's dominance as the political and cultural center of Rus. The Vladimir-Suzdal Principality became one of the largest and most powerful, and from that time its role began to grow, while Kyiv's importance began to decline."
                                        },
                                        new Content()
                                        {
                                            Id = 17,
                                            Text = "Крім того, в цей час на Русі значно зміцнився вплив Південного заходу — Галицько-Волинське князівство, яке стало важливим політичним і економічним центром. Це також сприяло посиленню боротьби між князівствами, хоча їхні конфлікти часто були пов'язані з боротьбою за ресурси, землі та торгові шляхи.",
                                            TextEng = "In addition, at this time, the influence of the South-West - the Galicia-Volhynia Principality, which became an important political and economic center, significantly strengthened in Rus'. This also contributed to the intensification of the struggle between the principalities, although their conflicts were often related to the struggle for resources, lands, and trade routes."
                                        },
                                        new Content()
                                        {
                                            Id = 18,
                                            Text = "Згодом Київ знову потрапив під контроль місцевих князів, проте його значення для Русі вже суттєво зменшилося. Власне, з цього періоду можна вважати початок розпаду єдиної держави і її перехід до більш децентралізованої структури, що завершилося в XIII столітті зі зростанням могутності монголо-татарського хана Батия і навалою монголів.\r\n\r\nТаким чином, за наступні кілька століть Русь зазнала значних змін, а її державна структура стала менш стабільною, розділяючись на окремі князівства.",
                                            TextEng = "Later, Kyiv again came under the control of local princes, but its importance for Rus had already significantly decreased. Actually, from this period we can consider the beginning of the collapse of the unified state and its transition to a more decentralized structure, which ended in the 13th century with the growth of the power of the Mongol-Tatar Khan Batu and the invasion of the Mongols.\r\n\r\nThus, over the next few centuries, Rus underwent significant changes, and its state structure became less stable, dividing into separate principalities."
                                        },
                                        new Content()
                                        {
                                            Id = 19,
                                            Text = "Після того, як Київ втратив свою роль як політичний центр на Русі, боротьба між князівствами загострилася, і з кожним роком розрізненість держави ставала дедалі помітнішою. Володимиро-Суздальське князівство стало основною силою на північному сході Русі, в той час як Галицько-Волинське князівство набирало потужності на заході. Ці дві великі держави, які й до цього мали певні суперечності, почали активно боротися за вплив.",
                                            TextEng = "After Kyiv lost its role as the political center of Rus, the struggle between the principalities intensified, and with each passing year the fragmentation of the state became more and more noticeable. The Vladimir-Suzdal principality became the main force in the northeast of Rus, while the Galicia-Volhynia principality gained power in the west. These two great states, which had already had certain contradictions, began to actively struggle for influence."
                                        },
                                        new Content()
                                        {
                                            Id = 20,
                                            Text = "Розділеність наростала. Князі сварилися, заключали союзи й зраджували один одного. Кров лилася не лише в боях із зовнішнім ворогом, а й між братами-русами. І коли земля здригалася від кінських копит своїх, у полях було не чути пісень — тільки стогін мечів і прокляття поранених.",
                                            TextEng = "The division grew. The princes quarreled, made alliances and betrayed each other. Blood was shed not only in battles with the external enemy, but also between the Rus brothers. And when the earth trembled from the hooves of their horses, no songs could be heard in the fields - only the groans of swords and the curses of the wounded."
                                        },
                                        new Content()
                                        {
                                            Id = 21,
                                            Text = "Тим часом на сході, далеко за степами, народжувалася нова сила — монголи. Вони об'єднували розпорошені орди під єдиною рукою Чингісхана, творячи величезну військову машину, здатну розчавити цілі народи. Спочатку руси чули про них лише як про страшні чутки, як про бурю, що ніколи не дійде до їхніх земель.",
                                            TextEng = "Meanwhile, in the east, far beyond the steppes, a new power was emerging - the Mongols. They united the scattered hordes under the single hand of Genghis Khan, creating a huge military machine capable of crushing entire peoples. At first, the Rus' heard of them only as terrible rumors, as a storm that would never reach their lands."
                                        },
                                        new Content()
                                        {
                                            Id = 22,
                                            Text = "Але буря вже насувалася. У 1222 році перші розвідницькі загони монголів під проводом Субедея і Джебе зруйнували державу хорезмшахів, і, переслідуючи ворогів, почали проникати в половецькі степи. Половці, знесилені й розгромлені, звернулися до руських князів, просячи допомоги.",
                                            TextEng = "But the storm was already approaching. In 1222, the first reconnaissance detachments of the Mongols under the leadership of Subedei and Jebe destroyed the state of the Khorezmshahs and, pursuing their enemies, began to penetrate the Polovtsian steppes. The Polovtsians, exhausted and defeated, turned to the Russian princes for help."
                                        },
                                        new Content()
                                        {
                                            Id = 23,
                                            Text = "Важкі рішення стояли перед руськими володарями. Довелося кидати свої чвари й збиратися на раду. Тоді вперше за багато років руські князі об'єдналися, зібрали війська й рушили на допомогу половцям. Їх об'єднало не бажання братства, а страх перед невідомим ворогом, що нищив усе на своєму шляху.",
                                            TextEng = "Difficult decisions faced the Rus' rulers. They had to put aside their quarrels and gather for a council. Then, for the first time in many years, the Rus' princes united, gathered their troops, and set out to help the Polovtsy. They were united not by a desire for brotherhood, but by fear of an unknown enemy that was destroying everything in its path."
                                        },
                                        new Content()
                                        {
                                            Id = 24,
                                            Text = "На цих гнилих коренях невпевненого союзу і виросла похідна дружина, що врешті зійдеться з монголами на берегах річки Калки — з надією на перемогу і вірою в свою силу, але ще не знаючи, яка прірва чекає їх попереду.",
                                            TextEng = "On these rotten roots of an uncertain alliance grew the marching army that would eventually meet the Mongols on the banks of the Kalka River — with hope for victory and faith in their strength, but not yet knowing what abyss awaited them ahead."
                                        },
                                        new Content()
                                        {
                                            Id = 25,
                                            Text = "Світ стояв на порозі бурі, і ми, князі руські, вперше за довгий час сіли разом — не заради суперечок про межі, не задля кривд і сварок за Київ, а щоб дати відповідь новій, нечуваній загрозі. Половецький хан Котян прибув до нас — не з гордістю, а з благанням. Він впав на коліна перед престолами тих, кого ще вчора вважав ворогами. Його очі були очима людини, що бачила пекло і вижила. Його слова були, мов крик вирваного з серця: «Монголи йдуть. Нас не стане. Ви будете наступними».",
                                            TextEng = "The world stood on the threshold of a storm, and we, the princes of Rus, sat together for the first time in a long time - not for the sake of disputes about borders, not for grievances and quarrels over Kyiv, but to respond to a new, unprecedented threat. The Polovtsian Khan Kotyan arrived to us - not with pride, but with a plea. He fell to his knees before the thrones of those whom he had considered enemies only yesterday. His eyes were the eyes of a man who had seen hell and survived. His words were like a cry torn from the heart: \"The Mongols are coming. We will not be enough. You will be next.\""
                                        },
                                        new Content()
                                        {
                                            Id = 26,
                                            Text = "Тоді ми, Ярослав Володимирович, Мстислав Удатний, Мстислав Романович Київський та інші, зібрали велику раду. Щити підперли стіни, мечі поклали на дошки — не для сварки, а як обітницю. Ми згадали давню присягу братерства, ще з часів, коли русин стояв за русина, і вирішили: рушимо разом, об’єднаємо сили з половцями, вдаримо першими — поки вони не дісталися наших дітей, наших церков, наших земель.",
                                            TextEng = "Then we, Yaroslav Volodymyrovych, Mstislav Udatny, Mstislav Romanovych of Kyiv and others, gathered a great council. We propped up the walls with shields, laid our swords on boards — not for a quarrel, but as a vow. We remembered the ancient oath of brotherhood, from the times when a Ruthenian stood for a Ruthenian, and decided: let us move together, join forces with the Polovtsy, strike first — before they get to our children, our churches, our lands."
                                        },
                                        new Content()
                                        {
                                            Id = 27,
                                            Text = "З Володимира і Галича рушили тисячі ратників — кінні, піші, зі списами й луками, з бойовими сокирами і бронзовими натільниками. Сузір’я дружинників потяглося по річках і рівнинах на схід. Кожен загін мав свого прапороносця, кожен мав свою клятву — не повернутись, поки степ не буде очищено.",
                                            TextEng = "Thousands of warriors set out from Volodymyr and Halych — on horseback, on foot, with spears and bows, with battle axes and bronze breastplates. The constellation of warriors stretched along the rivers and plains to the east. Each detachment had its own standard-bearer, each had its own oath — not to return until the steppe was cleared."
                                        },
                                        new Content()
                                        {
                                            Id = 28,
                                            Text = "Половці дали нам провідників. Ми йшли невідомими стежками, але з вірою в себе. А в самому серці — тривога. Ми не знали ворога. Ми не знали, скільки їх, які вони, що за звір той, що зветься монголом. І хоч князі кріпили один одного словом і молитвою, в очах бояр уже читалася стримана підозра — чи не ведуть нас чужинці на згубу?",
                                            TextEng = "The Polovtsy gave us guides. We walked along unknown paths, but with faith in ourselves. And in our hearts there was anxiety. We did not know the enemy. We did not know how many there were, what kind of beast they were, what kind of beast was this Mongol. And although the princes strengthened each other with words and prayers, a restrained suspicion was already visible in the eyes of the boyars - were the strangers leading us to destruction?"
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Калка",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 20000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 90
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 90
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        public List<Achievements> InitAchivs()
        {
            return new List<Achievements>()
            {
                new Achievements()
                {
                    Id = 0,
                    Name = "Перша перемога",
                    NameEng = "First win",
                    Description = "Вм перемогли в своїй першій битві",
                    DescriptionEng = "You win in first battle",
                    IconUrl = "https://d1red3q7jhuy4m.cloudfront.net/6a/ae/51c3-2afd-5c44-bf1b-931f430e90c0.jpg"
                },
                new Achievements()
                {
                    Id = 1,
                    Name = "Перша поразка",
                    NameEng = "First lose",
                    Description = "Ви вперше програли у битві",
                    DescriptionEng = "You first lose in battle",
                    IconUrl = "https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/apps/1151130/49f31c471f954cd4214267530b63e408a3c28d63.jpg"
                },
                new Achievements()
                {
                    Id = 2,
                    Name = "Історичне закінчення 1 рівня",
                    NameEng = "History end 1 level",
                    Description = "Історичне завершення першого рівня",
                    DescriptionEng = "History end first level",
                    IconUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-IxwKJ456bRwiGaf1yHEnpw0_wb8RydCI6w&s"
                }
            };
        }

        public Game InitGame(List<Level> levels, List<Achievements> achivs)
        {
            return new Game()
            {
                Id = 0,
                PlayerData = new Player(),
                Levels = levels,
                Achievements = achivs
            };
        }

        private void Awake()
        {
            List<Parametrs> parametrs = new List<Parametrs>();
            List<Level> levels = new List<Level>();
            List<Achievements> achievements = new List<Achievements>();

            parametrs = InitParam();
            levels = InitLevels(parametrs);
            achievements = InitAchivs();

            Game game = InitGame(levels, achievements);
            Save save = new Save();
            save.SaveStartGame(game);
            PlayerPrefs.SetString("OurLeader", "");
            PlayerPrefs.SetString("EnemyLeader", "");
            PlayerPrefs.SetString("WhoWin", "");
            PlayerPrefs.SetInt("OurArmy", 0);
            PlayerPrefs.SetInt("EnemyArmy", 0);
            PlayerPrefs.SetInt("OurOrg", 0);
            PlayerPrefs.SetInt("EnemyOrg", 0);
            PlayerPrefs.SetInt("OurBoyDuh", 0);
            PlayerPrefs.SetInt("EnemyBoyDuh", 0);
        }
    }
}