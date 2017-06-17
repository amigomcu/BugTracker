# Copyright c 2003-2005 Wang, Chun-Pin All rights reserved.
#
# Version:	$Id: string.cs,v 1.17 2013/07/07 21:37:27 alex Exp $
#

[common]
copy_right = "Copyright 2003-2009 Wang, Chun-Pin. Všechna práva vyhrazena."
login_hint = "Pro přihlášení do @key@ použijte platný e-mail a heslo."
hint_title = "Online nápověda"
button_submit = "Odeslat"
button_reset = "Resetovat"
button_create = "Vytvořit"
button_done = "Hotovo"
button_cancel = "Storno"
button_yes = "Ano"
button_no = "Ne"
button_ok = "OK"
back = "Zpět"
continue = "Pokračovat"
button_go = "Přejít"
title_project_list = "Seznam projektů"
title_feedback = "Zákaznická zpětná vazba"
title_schedule = "Kalendář"
title_document = "Dokumenty"
title_information = "Informace"
title_system = "Systém"
title_logout = "Odhlášení"
project_name = "Jméno projektu"
created_by = "Autor"
created_date = "Datum vytvoření"
function = "Funkce"
edit = "Upravit"
update = "Aktualizovat"
delete = "Smazat"
top = "Nahoru"
login = "Přihlášení"
colon = ":"
question_mark = "?"
yes = "Ano"
no = "Ne"
select_all = "Označit vše"
report = "Hlášení"
project = "Projekt"
user = "Uživatel"
group = "Skupina"
filter = "Filtr"
customer = "Zákazník"
document = "Dokument"
reserve_hint = "@key@ nemůže obsahovat následující znaky: @string@"
delete_note = "Všechna pole spojená s @key@ budou vymazána. Opravdu smazat?"
msg_title_login = "Přihlášení"
msg_title_oops = "Škoda..."
msg_title_success = "Úspěch..."
loading = "Načítání..."
basic_information = "Základní informace"
prevpage = "Předchozí"
nextpage = "Další"

[system]
user_management = "Správa uživatelů"
group_management = "Správa skupin"
my_account = "Můj účet"
feedback_system = "Systém zpětné vazby"
customer_management = "Správa zákazníků"
status_management = "Správa stavů"
syslog = "Systémový log"
feedback_syslog = "Log systému zpětné vazby"
preference = "Možnosti"
login_statistic = "Statistiky přihlášení"
statistic_new_report = "Statistiky nových hlášení"
statistic_status = "Statistiky stavů hlášení"
statistic_status_addon = "Statistiky stavů hlášení Addon"
statistic_feedback_report = "Statistiky hlášení zpětné vazby"
current_location = "Současné umístění"
system_info = "Systémové informace"
system_about = "O aplikaci"

[system_info]
system_usage = "Využití systému"
count_user = "Počet uživatelů v systému"
count_customer_user = "Počet zákazníků v systému"

[sysconf]
system_config = "Konfigurace"
basic_config = "Základní konfigurace"
mail_config = "Oznámení e-mailem"
limit_config = "Omezení systému"
program_name = "Název programu"
date_format = "Formát data"
auto_redirect = "Automatické přesměrování"
auth_method = "Metoda ověření normálních uživatelů"
auth_native = "Ukládat hesela uživatelů v databázi Bug Trackeru"
auth_imap = "Používat IMAP server"
imap_server = "IMAP server"
imap_port = "IMAP port"
mail_from_name = "Jméno odesílatele při odesílání systémového e-mailu"
mail_from_email = "E-mail odesílatele"
mail_function = "Funkce sendmail"
mail_function_hint = "Pokud váš systém nemá sendmail nebo e-mailový server vyžaduje ověření pro odeslání e-mailu, použijte &quot;Použít SMTP funkci Bug Trackeru&quot;"
mail_function_nosendmail = "Neodesílat e-mail"
mail_function_sendmail = "Použít PHP funkci mail()"
mail_function_phpsmtp = "Použít SMTP funkci Bug Trackeru"
mail_smtp_server = "SMTP server"
mail_smtp_port = "SMTP port"
mail_smtp_auth = "Vyžadováno ověření"
mail_smtp_user = "SMTP uživatel"
mail_smtp_password = "SMTP heslo"
allow_subscribe = "Umožnit uživatelům přihlásit se k odběrům"
allow_subscribe_hint = "Pokud se uživatel přihlásí k odběru projektu, obdrží e-mail při vytvoření nebo aktualizaci hlášení."
max_area = "Maximální oblast"
max_minor_area = "Maximální podoblast"
max_filter_per_user = "Maximální počet filtrů pro každého uživatele"
max_shared_filter = "Maximální počet sdílených filtrů pro každého uživatele"
max_syslog = "Maximální počet položek v logu"

[user]
id = "ID"
edit_user = "Upravit uživatele"
new_user = "Nový uživatel"
username = "Uživatelské jméno"
email = "E-mail"
password = "Heslo"
verify_password = "Heslo znova"
passwd_leave_empty = "Ponechte prázdné pro zachování starého hesla"
account_status = "Stav účtu"
account_enabled = "Povolen"
account_disabled = "Zakázán"
language = "Jazyk systému"
project_visible = "Viditelnost projektu"
group_name = "Jméno skupiny"
real_name = "Skutečné jméno"
show_valid = "Zobrazit jen aktivní uživatele"
show_disabled = "Zobrazit jen zakázané uživatele"
show_all = "Zobrazit všechny užívatele"
report_per_page = "Hlášení na stránce"
default_filter = "Výchozí filtr"
show_shared_filter = "Zobrazit sdílené filtry"
show_in_blank = "Zobrazit hlášení v novém okně"
columns_to_display = "Sloupce k zobrazení"
edit_group = "Upravit skupinu"
new_group = "Nová skupina"
group_privilege = "Práva skupiny"
status_allow = "Povolení stavů"

[customer]
new_customer = "Nová skupina zákazníka"
edit_customer = "Upravit skupinu zákazníka"
new_customer_user = "Nový uživatel zákazníka"
edit_customer_user = "Upravit uživatele zákazníka"
customer_name = "Jméno zákazníka"
customer_user = "Uživatel zákazníka"
address = "Adresa"
tel = "Telefon"
fax = "Fax"
auto_cc_to = "Přijmout upozornění při hlášení jiného zákazníka ze stejné skupiny"

[privilege]
can_admin_user = "Administrace uživ. účtů"
can_admin_customer = "Správa zákazníků"
can_create_project = "Vytvoření nového projektu"
can_update_project = "Upravení projektu"
can_delete_project = "Smazání projektu"
can_create_report = "Vytvoření nového hlášení"
can_update_report = "Aktualizace hlášení"
can_delete_report = "Smazání hlášení"
can_admin_feedback = "Správa systému zpětné vazby"
can_admin_faq = "Správa FAQ"
can_admin_status = "Upravení stavu"
can_see_document = "Prohlédnutí dokumentu"
can_create_document = "Vytvoření dokumentu"
can_update_document = "Upravení jiného dokumentu"
can_delete_document = "Smazání jiného dokumentu"
can_edit_selfdata = "Upravení vlastního účtu"
can_see_schedule = "Zobrazení kalendáře"
can_edit_schedule = "Upravení kalendáře"
can_see_sysinfo = "Zobrazení syst. informací"
can_see_statistic = "Zobrazení statistiky systému"
can_manage_document_class = "Správa kategorií dokumentů"
can_manage_label = "Správa jmenovek"

[project]
new_project = "Nový projekt"
edit_project = "Upravit projekt"
new_report = "Nové hlášení"
edit_report = "Upravit hlášení"
show_report = "Zobrazit hlášení"
task_force = "Vynutit úlohu"
auto_mailto = "Automatický e-mail"
auto_mailto_hint = "Uživatelé v tomto seznamu obdrží e-mail při aktualizaci hlášení. Najčastěji jde o projektové manažery, kteří musí mít přehled o změnách a stavu všech hlášení."
feedback_mailto = "Oznámení o zpětné vazbě"
feedback_mailto_hint = "Jestliže zákazník přidá hlášení do systému zpětné vazby, bude uživatelům z tohoto seznamu odeslán skrytý e-mail a jeho kopie uživatelům v seznamu "Automatický e-mail"."
version_pattern = "Vzor verze"
version_pattern_hint = "Systém vygeneruje rozbalovací seznam podle vzoru verze. Pokud chcete v rozbalovacím seznamu použít čísla, použijte % místo čísla. Pokud chcete v rozbalovacím seznamu použít písmena, použijte @ místo písmena. Pokud je například Vaše verze SDS-1-1.12 a chcete, aby rozbalovací seznam měl verzi 1.12, vzor by měl být SDS-1-%.%%."
accessible_by = "Dostupnost"
area_minor_area = "Oblast/Podoblast"
area_edit_hint = "Klepněte zde pro úpravu oblastí"
area_owner = "Majitel"
area = "Oblast"
minor_area = "Podoblast"
select_hint = "Stiskem Ctrl nebo Shift označíte více položek."
all_user_list = "Seznam všech uživatelů"
accessible_user_list = "Seznam uživatelů s přístupem"
access_add = "Přidat >>"
access_remove = "<< Odebrat"
priority_very_low = "Velmi nízká"
priority_low = "Nízká"
priority_normal = "Normální"
priority_high = "Vysoká"
priority_very_high = "Velmi vysoká"
reproducibility_ididnttry = "Nezkoušel-a jsem"
reproducibility_rarely = "Zřídka"
reproducibility_sometimes = "Častěji"
reproducibility_always = "Vždy"
type_bug = "Chyba"
type_feature = "Vlastnost"
type_usability = "Zlepšení"
type_document = "Dokument"
view_printable = "Zobrazit stránku pro tisk"
subscribe_list = "Seznam odběrů"
subscribe = "Přihlásit k odběru"
unsubscribe = "Odhlásit z odběru"
subscribe_hint = "Přihlášení k odběru bylo úspěšné. Při vytvoření nebo aktualizaci hlášení obdržíte upozornění."

[filter]
set_filter = "Nastavit filtr"
filter_name = "Jméno filtru"
new_filter = "Nový filtr"
show_filter = "Zobrazit filtr"
merge_above_op = "Operátor pro spojení pravidel"
next_filter_hint = "Pro nastavení více pravidel na další stránce zvolte jeden z operátorů na jejich propojení"
no_filter_now = "Nebyl definován žádný filtr."
last_update = "Poslední aktualizace"
share_filter = "Sdílet tento filtr"
to_many_filter = "Máte nastaveno príliš mnoho společných filtrů."
current_filter = "Sočasné pravidlo filtru"
all_active_bugs = "Všechny aktivní chyby"
all_closed_bugs = "Všechny uzavřené chyby"
assigned_to_me = "- Priřazeno mně"
fixed_by_me_last_week = "- Mnou opraveno poslední týden"
greater_than = "Větší než"
less_than = "Menší než"
equals_to = "Rovná se"
not_equals_to = "Nerovná se"
date_before = "Před"
date_after = "Po"

[reportlist]
search = "Hledaní"
search_hint = "Vložením #34 přejdete na hlášení s ID 34. Také můžete použít logické operátory "and", "or", "not". Např. "chyba and síť" bude hledat v názvech a popisech hlášení slova chyba a síť."
subject_and_content = "Předmět a popis"
total = "Celkem"
items = "položek"
page = "Stránka"
prev_page = "Předchozí"
next_page = "Další"
match = "Odpovídá"
copy_to = "Kopírovat do"
summary = "Přehled"
reported_by = "Nahlásil"
priority = "Priorita"
status = "Stav"
fixed_by = "Opraveno"
fixed_date = "Datum opravy"
version = "Verze"
fixed_in_version = "Opraveno ve verzi"
assign_to = "Priřazeno"
verified_by = "Ověřeno"
verified_date = "Datum ověření"
estimated_time = "Odhadovaný čas"
reproducibility = "Reprodukovatelnost"
see_also = "Viz také"
see_also_hint = "Vložte ID. POkud je jich více, oddělte je &quot,&quot"
file_upload = "Nahrát soubor"
file_upload_hint = "Nahrajte otisky obrazovky nebo logy. Maximální velikost"
type = "Typ"
logs = "Logy"
description = "Popis"
reported_by_customer = "Hlášeno zákazníkem"
description_hint = "Vložte detaily o hlášení. Pokud je to použitelné, pokuste se také obsáhnout:<ul><li>Model přístroje, velikost paměti, verzi FW</li><li>Vámi uskutečněné kroky,</li><li>co jste předpokládali</li><li>a co jste místo toho viděli.</li></ul>"
export = "Exportovat"
export_columns = "Sloupce k exportu"
stauts_changes_assign_to = ""Status" byl změněn, ale "Assign To" ne. Chcete nyní odeslat?"

[document]
document_class = "Kategorie dokumentů"
new_document_class = "Nová kategorie dokumentů"
edit_document_class = "Upravit kategorii dokumentů"
all_document_class = "Všechny kategorie"
belong_document_class = "Navštívené kategorie"
subject = "Předmět"
file = "Soubor"
new_document = "Nový dokument"
edit_document = "Aktualizovat dokument"
document_upload_hint = "Nahrajte dokument. Maximální velikost"
exceed_max_size = "File is too big. Max upload size: @string@"
document_update_hint = "Nově nahraný soubor přepíše stávající. Pokud chcete starý soubor smazat, zvolte možnost pro smazání."
original_document = "Originální dokument"
none = "Žádný"
remove_old_document = "Smazat soubor"
group_class = "Zařadit do skupiny"
allow_other_group = "Umožnit přístup jiným skupinám"
show_doc_for_group = "Zobrazit dokumenty pro skupinu"
document_search_hint = "Můžete používat hledaní pomocí klíčových slov. Systém zobrazí položky, které obsahují klíčové slovo v názvu a popisu. Můžete také vložit operátory "and", "or", "not". Např. "chyba and síť" bude v názvu a popisu hledat slova chyba a síť."
all_groups = "Všechny skupiny"
document_setting = "Nastavení dokumentů"
history = "Historie"
document_history = "Historie dokumentů"
document_restore = "Obnovit tuto verzi"
document_restore_confirm = "Opravdu chcete obnovit tento dokument na současnou verzi?"
show_document = "Zobrazit dokument"
show_history_doc = "Zobrazit historii dokumentů"

[status]
new_status = "Nový stav"
edit_status = "Upravit stav"
color = "Barva"
status_name = "Jméno stavu"
color_hint = "Můžete použít rozsah barev HTML, např. black, blue, #FFCC00, #EE0101"
status_type_active = "Active"
status_type_closed = "Closed"

[error]
project_id = "ID projektu"
report_id = "ID hlášení"
document_id = "ID dokumentu"
group_id = "ID skupiny"
filter_id = "ID filtru"
user_id = "ID uživatele"
customer_id = "ID zákazníka"
customer_user_id = "ID uživatele zákazníka"
condition = "Pravidlo filtru"
no_such_xxx = "@key@ neexistuje."
no_setting = "Není možné získat Vaše možnosti."
return_try = "Zkuste to později."
error_title = "V průběhu operace se vyskytla chyba."
no_privilege = "Nemáte práva pro tuto operaci."
timeout = "Timeout nebo nepřihlášen."
auth_failed = "Ověření selhalo."
auth_imap_failed = "Ověření IMAP selhalo."
miss_parameter = "Chybějící parameter: @key@"
no_empty = "Toto: @key@ nemůže být prázdné."
too_long = "@key@ je příliš dlouhý, nesmí přesahovat @string@."
have_same = "V systému je jiný @key@ [@string@]."
password_not_match = "Hesla nesouhlasí."
wrong_format = "Formát @key@ je chybný."
no_seealso_id = "Není možné najít a zobrazit @string@."
error_hint = "Pokud se tato chyba bude opakovat, obraťte se na administrátora systému."
finish_mesg = "Aktualizace dat byla úspěšná. Konfigurace byla uložena."
finish_update ="Aktualizace @key@ byla úspěšná."
finish_new = "Vytvoření @key@ bylo úspěšné."
finish_import = "Import @key@ byl úspěšný."
finish_delete = "Smazání @key@ bylo úspěšné."
finish_password_send = "Na Váš e-mail Vám bylo zasláno nové heslo."
db_error = "Při přístupu do databáze se vyskytla chyba na stránce [@string@]."
system_reserve_word = "@key@ [@string@] je vyhrazen pro potřeby systému."
input_the_follow_info = "Vložtenásledující informaci"

[syslog]
time = "Čas"
ip = "IP"
clear_syslog = "Vymazat všechny systémové logy"
clear_feedback_syslog = "Vymazat všechny přístupové logy systému zpětné vazby"
refresh = "Obnovit"
syslog_new_xxx = "Vytvoření @key@ [@string@] bylo úspěšné."
syslog_edit_xxx = "Úprava @key@ [@string@] byla úspěšná."
syslog_delete_xxx = "Smazání @key@ [@string@] bylo úspěšné."
syslog_login_failed = "Chybné přihlášení uživatele [@string@]."
syslog_login = "Přihlášení uživatele [@string@] bylo úspěšné."
syslog_miss_arg = "Vážná chyba. Stránka [@string@] neobdržela předpokládané parametry."
syslog_permission_denied = "Uživatel se pokusil o přístup na nepovolenou stránku [@string@]."
syslog_not_found = "Chyba při hledání @key@, který hledal uživatel na stránce [@string@]."

[statistic]
login_times = "Počet přihlášení"
period = "Období"
latest_week = "Poslední týden"
latest_month = "Poslední měsíc"
latest_half_year = "Poslední půlrok"
latest_year = "Poslední rok"
period_day = "den"
period_week = "týden"
period_month = "měsíc"
count_number = "Počet"
all_priorities = "Vše"
empty_priorities = "(prázdné)"

[feedback]
feedback_login_hint = "Pro přihlášení do @key@ použijte platný e-mail a heslo."
feedback_system_name = "Jméno systému"
login_mode = "Mód přihlášení do systému zpětné vazby"
login_mode_hint = "V zákazníckém módu mají přístup do systému jen zaregistrovaní zákazníci. V anonymním módu si mohou uživatelé registrovat svůj vlastní účet online. Pokud chcete zakázat systém zpětné vazby, změňte mód přihlášení na 'Vypnuto'."
mode_disabled = "Vypnuto"
mode_customer = "Zákaznický mód"
mode_anonymous = "Anonymní mód"
mode_both = "Oba režimy"
no_account_yet = "Nemáte ještě účet?"
register_account = "Vytvořit účet"
forget_password = "Zapomenuté heslo"
forget_password_title = "Odeslat nové heslo"
forget_password_hint = "Systém odešle nové heslo na Váš e-mail. Jakmile jej obdržíte, použijte jej pro přihlášení. V opačném případě bude heslo po 10 dnech opět neplatné."
new_password = "Nové heslo"
customer_filter = "Vybrat zákazníka"
import = "Importovat do vnitřního systému"
import_notice = "Poznámka: Logy výše nebudou importovány do vnitřního systému. Budete muset vložit potřebné informace a nahrát soubor sami."
import_description = "Výchozí odpověď při importu hlášení"
import_description_hint = "Obsah výchozí odpovědi při importu hlášení do vnitřního systému ze zpětné vazby zákazníka. Systém zákazníkovi odpoví tímto textem."
imported_report = "ID importovaného hlášení"
closed_description = "Zpráva připojená k hlášení při ukončení importovaného vnitřního hlášení"
closed_description_hint = "Po importu do vnitřního systému a pokud je vnitřní hlášení ukončeno, bude automaticky připojena k hlášení tato zpráva. Poznámka: Řetězec "__STATUS__" bude nahrazen stavem uzavření vnitřního hlášení."
all_customers = "Všechni zákazníci"

[faq]
faq = "FAQ"
faq_class = "Kategorie FAQ"
new_faq_class = "Nová kategorie FAQ"
edit_faq_class = "Upravit kategorii FAQ"
all_class_name = "Všechny kategorie FAQ"
belong_class_name = "Propojené kategorie FAQ"
class_name = "Kategorie"
new_faq = "Nová FAQ"
edit_faq = "Upravit FAQ"
question = "Otázka"
answer = "Odpověď"
is_verified = "Je ověřeno"
faq_verified_by = "Ověřil"
faq_verified_date = "Datum ověření"
faq_verified_hint = "Tyto FAQ můžete zadat jiné osobě k ověření a potvrzení obsahu. Jen ověřené FAQ se zobrazí v systému zákaznické zpětné vazby. Jestliže jsou tyto FAQ ověřené, systém je osamostatní od priřazení k nějaké osobě."
html_hint = "Můžete používat HTML tagy k úpravě obsahu, např. table, list, atd. Poznámka: musíte přidat <br> nebo <p> pro přidání nového řádku nebo odstavce."
faq_search_hint = "Můžete používat hledaní pomocí klíčových slov. Systém zobrazí položky, které obsahují klíčové slovo v otázce nebo odpovědi."
all_classes = "Vše"
faq_setting = "Nastavení FAQ"

[schedule]
schedule_for = "Kalendář pro:"
date = "Datum"
content = "Obsah"
new_schedule = "Nová událost"
show_schedule = "Zobrazit událost"
edit_schedule = "Upravit událost"
schedule_type = "Typ události"
project_schedule = "Událost Projekt"
personal_schedule = "Událost Osobní"
publish_schedule = "Událost Publikace"
publish_hint = "Nastavte publikování na Ano, pokud chcete, aby ostatní uživatelé viděli tuto událost. Upravit nebo odstranit ji však může pouze autor."
schedule_emailto = "Odeslat upozornění"
schedule_emailto_hint = "Po přidaní systém pošle upozornění na tuto adresu. Pokud potřebujete více příjemců, použijte čárku "," pro oddělení."
all_schedule = "Všechny události"
today = "Dnes"
sunday = "Neděle"
monday = "Pondělí"
tuesday = "Úterý"
wednesday = "Středa"
thursday = "Čtvrtek"
friday = "Pátek"
saturday = "Sobota"

[label]
new_label = "Nová jmenovka"
label = "Jmenovka"
apply_label = "Použít jmenovku"
remove_label = "Odebrat jmenovku"
search_label = "Vyhledávání jmenovku"
please_select_item = "Zvolte položku k použití"
label_actions = "Akce jmenovky..."
label_management = "Správa jmenovek"
label_color = "Barva"
edit_label = "Upravit jmenovku"

[email]
new_user_email_subject = "Welcome to @program_name@!!"
new_user_email_text = "<p>Hi @username@,</p><p>Your account on @program_name@ has been created.<p>Username: @username@<br>Password: @password@</p><p>Please login here:<br>@url@</p><p>Thanks,<br>@mail_from_name@</p>"
update_user_email_subject = "Password changed on @program_name@!!"
update_user_email_text = "<p>Hi @username@,</p><p>Your password on @program_name@ has been changed.<p>Username: @username@<br>Password: @password@</p><p>Please login here:<br>@url@</p><p>Thanks,<br>@mail_from_name@</p>"
faq_email_subject = "[@project_name@][FAQ][id:@id@] Please verify this FAQ"
faq_email_text = "<p>Hi,</p><p>Please help me to verify this FAQ and update the FAQ status on the system.</p><p>--</p><p>Question:</p><blockquote>@question@</blockquote><p>Answer:</p><blockquote>@answer@</blockquote>"
feedback_new_user_email_subject = "Welcome to @program_name@!!"
feedback_new_user_email_text = "<p>Hi @username@,</p><p>Your account on @program_name@ has been created.<p>Username: @username@<br>Password: @password@</p><p>Thanks,<br>@mail_from_name@</p>"
feedback_update_user_email_subject = "Password changed on @program_name@!!"
feedback_update_user_email_text = "<p>Hi @username@,</p><p>Your password on @program_name@ has been changed.<p>Username: @username@<br>Password: @password@</p><p>Thanks,<br>@mail_from_name@</p>"
feedback_register_subject = "Welcome to @program_name@!!"
feedback_register_text = "<p>Dear user,</p><p>This is your account on the @program_name@.</p><p>Username: @username@<br>Password: @password@</p><p>Please login in 10 days. Otherwise, the account would be disabled and you would have to register again.</p><p>Thanks,<br>@mail_from_name@</p>"
feedback_forget_pass_subject = "Your new password on @program_name@!!"
feedback_forget_pass_text = "<p>Dear user,</p><p>This is your new password on the @program_name@.</p><p>Username: @username@<br>Password: @password@</p><p>If you did not request this new password, just login with you old password. The system will remove this request.</p><p>Please login in 10 days. Otherwise, the new password would be disabled and you would have to request again.</p><p>Thanks,<br>@mail_from_name@</p>"
