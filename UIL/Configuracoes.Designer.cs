﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UIL {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Configuracoes : global::System.Configuration.ApplicationSettingsBase {
        
        private static Configuracoes defaultInstance = ((Configuracoes)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Configuracoes())));
        
        public static Configuracoes Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("campigoto")]
        public string Usuario {
            get {
                return ((string)(this["Usuario"]));
            }
            set {
                this["Usuario"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("036239")]
        public string Senha {
            get {
                return ((string)(this["Senha"]));
            }
            set {
                this["Senha"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Login_Automatico {
            get {
                return ((bool)(this["Login_Automatico"]));
            }
            set {
                this["Login_Automatico"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Mensagem_Gravar {
            get {
                return ((bool)(this["Mensagem_Gravar"]));
            }
            set {
                this["Mensagem_Gravar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Cidade_Padrao {
            get {
                return ((int)(this["Cidade_Padrao"]));
            }
            set {
                this["Cidade_Padrao"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Tipo_Pagto {
            get {
                return ((int)(this["Tipo_Pagto"]));
            }
            set {
                this["Tipo_Pagto"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PROGRAMAS-NOTE\\SQLEXPRESS;Initial Catalog=AutoCenter;Integrated Secur" +
            "ity=True")]
        public string Conexao {
            get {
                return ((string)(this["Conexao"]));
            }
            set {
                this["Conexao"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=FELIPE-WIN8\\SQLEXPRESS;Initial Catalog=AutoCenter;Integrated Security" +
            "=true;")]
        public string Conexao2 {
            get {
                return ((string)(this["Conexao2"]));
            }
            set {
                this["Conexao2"] = value;
            }
        }
    }
}
