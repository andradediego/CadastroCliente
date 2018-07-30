#pragma checksum "D:\TesteAthos\CadastroUsuarios.Cliente\CadastroUsuarios.Cliente\Views\Usuarios\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c9db699efead570bd416cfff1aa1e679ff6bf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Consultar), @"mvc.1.0.view", @"/Views/Usuarios/Consultar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Consultar.cshtml", typeof(AspNetCore.Views_Usuarios_Consultar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\TesteAthos\CadastroUsuarios.Cliente\CadastroUsuarios.Cliente\Views\_ViewImports.cshtml"
using CadastroUsuarios.Cliente;

#line default
#line hidden
#line 2 "D:\TesteAthos\CadastroUsuarios.Cliente\CadastroUsuarios.Cliente\Views\_ViewImports.cshtml"
using CadastroUsuarios.Cliente.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c9db699efead570bd416cfff1aa1e679ff6bf6", @"/Views/Usuarios/Consultar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a7ba06f208d3772776c154bbdff64ecef861ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Consultar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\TesteAthos\CadastroUsuarios.Cliente\CadastroUsuarios.Cliente\Views\Usuarios\Consultar.cshtml"
  
    ViewData["Title"] = "Consultar Usuários";

#line default
#line hidden
            BeginContext(54, 81, true);
            WriteLiteral("<style>\r\n    .mensagem-padding {\r\n        padding: 15px;\r\n    }\r\n</style>\r\n\r\n<h2>");
            EndContext();
            BeginContext(136, 17, false);
#line 10 "D:\TesteAthos\CadastroUsuarios.Cliente\CadastroUsuarios.Cliente\Views\Usuarios\Consultar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(153, 351, true);
            WriteLiteral(@"</h2>

<div class=""row"" id=""pesquisa-usuario"">
    <div class=""col-xs-12 col-md-6 col-md-offset-3"">
        <p v-if=""erro"" v-bind:class=""{'bg-danger': erro}"" class=""mensagem-padding""><strong>{{ mensagemUsuario }}</strong></p>
        <label class=""radio-inline"">
            <input type=""radio"" name=""pesquisar"" value=""nome"" v-model=""pesquisar"" ");
            EndContext();
            BeginContext(505, 168, true);
            WriteLiteral("@click=\"ResetarValores\"> Nome\r\n        </label>\r\n        <label class=\"radio-inline\">\r\n            <input type=\"radio\" name=\"pesquisar\" value=\"cpf\" v-model=\"pesquisar\" ");
            EndContext();
            BeginContext(674, 573, true);
            WriteLiteral(@"@click=""ResetarValores""> CPF
        </label>
        <hr />

        <div class=""form-group"" v-if=""pesquisar == 'nome'"">
            <label for=""Nome"">Nome:</label>
            <input type=""text"" class=""form-control"" id=""Nome"" name=""Nome"" placeholder=""Nome"" v-model=""pesquisarNome"" />
        </div>

        <div class=""form-group"" v-if=""pesquisar == 'cpf'"">
            <label for=""CPF"">CPF:</label>
            <input type=""text"" v-mask=""'###.###.###-##'"" class=""form-control"" id=""CPF"" name=""CPF"" placeholder=""CPF"" v-model=""pesquisarCpf"" />
        </div>
");
            EndContext();
            BeginContext(1330, 2608, true);
            WriteLiteral(@"        <button class=""btn btn-primary"" v-on:click.prevent=""Pesquisar"">Pesquisar</button>
        <hr />
        <template v-if=""nome != ''"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Sobrenome</th>
                        <th>CPF</th>
                        <th>Telefone</th>
                        <th>Ações</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>{{nome}}</td>
                        <td>{{sobrenome}}</td>
                        <td>{{cpf}}</td>
                        <td>{{telefone}}</td>
                        <td>
                            <button type=""button"" class=""btn btn-default btn-xs"" aria-label=""Left Align"" data-toggle=""modal"" data-target=""#myModal"">
                                <span class=""glyphicon glyphicon-pencil"" aria-hidden=""true""></span>
          ");
            WriteLiteral(@"                  </button>

                            <button type=""button"" class=""btn btn-danger btn-xs"" aria-label=""Left Align"" v-on:click.prevent=""DeletarUsuario(id.toUpperCase())"">
                                <span class=""glyphicon glyphicon-trash"" aria-hidden=""true""></span>
                            </button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </template>


        <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                        <h4 class=""modal-title"" id=""myModalLabel"">Modal title</h4>
                    </div>
                    <div class=""modal-body"">
");
            WriteLiteral(@"                        <p v-if=""erro || sucesso"" v-bind:class=""{'bg-danger': erro, 'bg-success': sucesso}"" class=""mensagem-padding""><strong>{{ mensagemUsuario }}</strong></p>
                        <input type=""hidden"" v-model=""id"" />
                        <div class=""form-group"" v-bind:class=""{'has-error': $v.nome.$error}"">
                            <label for=""Nome"">Nome:</label>
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""Nome"" placeholder=""Nome""
                                   v-model.lazy=""nome"" ");
            EndContext();
            BeginContext(3939, 515, true);
            WriteLiteral(@"@input=""$v.nome.$touch()"" />
                            <span class=""help-block"" v-if=""$v.nome.$error"">Nome inválido</span>
                        </div>
                        <div class=""form-group"" v-bind:class=""{'has-error': $v.sobrenome.$error}"">
                            <label for=""Sobrenome"">Sobrenome:</label>
                            <input type=""text"" class=""form-control"" id=""Sobrenome"" name=""Sobrenome"" placeholder=""Sobrenome""
                                   v-model.lazy=""sobrenome"" ");
            EndContext();
            BeginContext(4455, 514, true);
            WriteLiteral(@"@input=""$v.sobrenome.$touch()"" />
                            <span class=""help-block"" v-if=""$v.sobrenome.$error"">Sobrenome inválido</span>
                        </div>
                        <div class=""form-group"" v-bind:class=""{'has-error': $v.cpf.$error}"">
                            <label for=""CPF"">CPF:</label>
                            <input type=""text"" v-mask=""'###.###.###-##'"" class=""form-control""
                                   id=""CPF"" name=""CPF"" placeholder=""CPF"" v-model.lazy=""cpf"" ");
            EndContext();
            BeginContext(4970, 552, true);
            WriteLiteral(@"@input=""$v.cpf.$touch()"" />
                            <span class=""help-block"" v-if=""$v.cpf.$error"">CPF inválido</span>
                        </div>
                        <div class=""form-group"" v-bind:class=""{'has-error': $v.telefone.$error}"">
                            <label for=""Telefone"">Telefone:</label>
                            <input type=""text"" v-mask=""['(##) ####-####', '(##) #####-####']"" class=""form-control"" id=""Telefone""
                                   name=""Telefone"" placeholder=""Telefone"" v-model.lazy=""telefone"" ");
            EndContext();
            BeginContext(5523, 6133, true);
            WriteLiteral(@"@input=""$v.telefone.$touch()"" />
                            <span class=""help-block"" v-if=""$v.telefone.$error"">Telefone inválido</span>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Fechar</button>
                        <button type=""button"" class=""btn btn-primary"" v-on:click.prevent=""EnviarFormulario($event)"">Salvar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    Vue.use(window.vuelidate.default);
    const { required } = window.validators;
    new Vue({
        el: '#pesquisa-usuario',
        data: {
            erro: false,
            sucesso: false,
            mensagemUsuario: '',
            pesquisar: 'nome',
            pesquisarNome: '',
            pesquisarCpf: '',
            id: '',
            nome: '',
            sobrenome: '',
         ");
            WriteLiteral(@"   cpf: '',
            telefone: ''
        },
        validations: {
            nome: {
                required
            },
            sobrenome: {
                required: required
            },
            cpf: {
                required: required,
                cpfValido: function (valor) {
                    var validarCPF = new CPF();
                    return validarCPF.valida(valor);
                }
            },
            telefone: {
                required: required
            }
        },
        methods: {
            ResetarValores: function () {
                switch (this.pesquisar) {
                    case 'nome':
                        this.pesquisarCpf = '';
                        break;
                    case 'cpf':
                        this.pesquisarNome = '';
                    default:
                        break;
                }
            },
            Pesquisar: function () {
                switch (this.pesquisar)");
            WriteLiteral(@" {
                    case 'nome':
                        var dados = {
                            nome: this.pesquisarNome,
                            cpf: null,
                        }
                        this.RealizarPesquisa(dados);
                        break;
                    case 'cpf':
                        var dados = {
                            cpf: this.pesquisarCpf,
                            nome: null,
                        }
                        this.RealizarPesquisa(dados);
                        break;
                    default:
                        break;
                }
            },
            DeletarUsuario: function (id) {
                var url = 'http://localhost:50858/api/Usuarios/DeletarUsuario';

                var dados = {
                    id: id
                };

                this.erro = false;

                try {
                    this.$http.post(url, dados).then(
                        function (da");
            WriteLiteral(@"ta) {
                            //console.log(data);
                            this.id = '';
                            this.nome = '';
                            this.sobrenome = '';
                            this.cpf = '';
                            this.telefone = '';
                        },
                        function (error) {
                            this.erro = true;
                            this.mensagemUsuario = error;
                        }
                    );
                } catch (e) {
                    this.erro = true;
                    this.mensagemUsuario = e;
                }
            },
            EnviarFormulario: function (e) {
                this.erro = false;
                this.sucesso = false;

                var url = 'http://localhost:50858/api/Usuarios/AtualizarUsuario';
                var dados = {
                    id: this.id,
                    nome: this.nome,
                    sobrenome: this.sobrenome,");
            WriteLiteral(@"
                    cpf: this.cpf,
                    telefone: this.telefone,
                };

                try {
                    this.$http.post(url, dados).then(
                        function (data) {
                            this.sucesso = true;
                            this.mensagemUsuario = 'Usuário ' + data.body.nome + ' atualizado com sucesso';
                            this.nome = '';
                            this.sobrenome = '';
                            this.cpf = '';
                            this.telefone = '';
                        },
                        function (error) {
                            this.erro = true;
                            this.mensagemUsuario = error;
                        }
                    );
                } catch (e) {
                    this.erro = true;
                    this.mensagemUsuario = e.message;
                }

            },
            RealizarPesquisa: function (dados) {
         ");
            WriteLiteral(@"       this.erro = false;

                var url = 'http://localhost:50858/api/Usuarios/ConsultarUsuario';

                try {
                    this.$http.post(url, dados).then(
                        function (data) {
                            console.log(data);
                            this.id = data.body.id;
                            this.nome = data.body.nome;
                            this.sobrenome = data.body.sobrenome;
                            this.cpf = data.body.cpf;
                            this.telefone = data.body.telefone;
                        },
                        function (error) {
                            this.erro = true;
                            this.mensagemUsuario = 'Nenhum usuário encontrado';
                        }
                    );
                } catch (e) {
                    this.erro = true;
                    this.mensagemUsuario = e;
                }
            }
        }
    });

</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
