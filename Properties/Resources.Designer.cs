﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirehoseFinder.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FirehoseFinder.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на О программе.
        /// </summary>
        internal static string about {
            get {
                return ResourceManager.GetString("about", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 1577249282:AAFIZncf-90YpwMk_I7ad_YNwh4tnr5FXHo.
        /// </summary>
        internal static string bot {
            get {
                return ResourceManager.GetString("bot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Icon, аналогичного (Значок).
        /// </summary>
        internal static System.Drawing.Icon fh {
            get {
                object obj = ResourceManager.GetObject("fh", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Fh_Image {
            get {
                object obj = ResourceManager.GetObject("Fh_Image", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 			Краткий инструктаж.
        ///
        ///	Основной функционал приложения - поиск подходящего программера (firehose, пожарный шланг, шланг и т.п.) под определённое устройство.
        ///	Так как устройств и шлангов много, то первым шагом и первой кнопкой является &quot;Опросить устройство с перезагрузкой в аварийный режим&quot;. Данная процедура необходима для получения идентификаторов устройства, по которым будет осуществляться подбор шланга. Все идентификаторы, иногда, не получается получить одним запросом. Для этого есть возможность внест [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string Greeting {
            get {
                return ResourceManager.GetString("Greeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Для вступления в силу изменения выбранного языка требуется перезапуск приложения. Нажмите &quot;Ок&quot; для перезагрузки приложения сейчас или &quot;Отмена&quot; для вступления изменений в силу при следующем запуске..
        /// </summary>
        internal static string message_body_need_restart {
            get {
                return ResourceManager.GetString("message_body_need_restart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Требуется перезапуск приложения!.
        /// </summary>
        internal static string message_title_need_restart {
            get {
                return ResourceManager.GetString("message_title_need_restart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap russia_flags_flag_17058 {
            get {
                object obj = ResourceManager.GetObject("russia_flags_flag_17058", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap united_kingdom_flags_flag_17079 {
            get {
                object obj = ResourceManager.GetObject("united_kingdom_flags_flag_17079", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Версия.
        /// </summary>
        internal static string version {
            get {
                return ResourceManager.GetString("version", resourceCulture);
            }
        }
    }
}
