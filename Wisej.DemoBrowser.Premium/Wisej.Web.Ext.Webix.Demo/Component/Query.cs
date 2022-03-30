using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
    public partial class Query : ViewBase
    {
        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            this.query1.Options.fields = new dynamic[]
            {
                new
                {
                    id = "first_name",
                    value = "First Name",
                    type = "text"
                },
                new
                {
                    id = "first_name",
                    value = "First Name",
                    type = "text"
                },
                new
                {
                    id = "first_name",
                    value = "First Name",
                    type = "text"
                }
            };

            this.query1.Options.value = new
            {
                glue = "or",
                rules = new dynamic[]
                {
                    new
                    {
                        field = "first_name",
                        includes = new[]{"Diana"}
                    },
                    new
                    {
                        field = "first_name",
                        includes = new[]{"Alex"}
                    },
                    new
                    {
                        glue = "and",
                        rules = new dynamic[]
                        {
                            new
                            {
                                field = "age",
                                condition = new[]
                                {
                                    new
                                    {
                                        type = "less",
                                        filter = 45
                                    }
                                }
                            },
                            new
                            {
                                field = "job",
                                condition = new[]
                                {
                                    new
                                    {
                                        type = "contains",
                                        filter = "lead"
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
