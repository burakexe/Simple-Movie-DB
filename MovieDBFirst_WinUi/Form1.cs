using MovieDBFirst_BLL.BaseRepository;
using MovieDBFirst_DAL;
using System;
using System.Windows.Forms;

namespace MovieDBFirst_WinUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BaseRepository<Genre> genreService = new BaseRepository<Genre>();
        private BaseRepository<Saloon> saloonService = new BaseRepository<Saloon>();
        private BaseRepository<Session> sessionService = new BaseRepository<Session>();
        private BaseRepository<Movy> movieService = new BaseRepository<Movy>();
        private BaseRepository<Theater> theaterService = new BaseRepository<Theater>();
        private BaseRepository<Director> directorService = new BaseRepository<Director>();

        private void Form1_Load(object sender, EventArgs e)
        {

            GenreLoad();
            SaloonLoad();
            SessionLoad();
            DirectorLoad();
            GetAll();
            IDHide();
        }

        // Used Methods //

        private void IDHide()
        {
            dgGenre.Columns[0].Visible = false;
            dgSaloon.Columns[0].Visible = false;
            dgSessions.Columns[0].Visible = false;
            dgDirectors.Columns[0].Visible = false;
        }

        private void GenreLoad()
        {
            cmbGenre.DisplayMember = "Name";
            cmbGenre.ValueMember = "GenreID";
            cmbGenre.DataSource = genreService.SelectAll();
            dgGenre.DataSource = genreService.SelectAll();
        }

        private void SaloonLoad()
        {
            cmbSaloon.DisplayMember = "Name";
            cmbSaloon.ValueMember = "SaloonID";
            cmbSaloon.DataSource = saloonService.SelectAll();
            dgSaloon.DataSource = saloonService.SelectAll();
        }

        private void SessionLoad()
        {
            cmbSession.DisplayMember = "Sessions";
            cmbSession.ValueMember = "SessionID";
            cmbSession.DataSource = sessionService.SelectAll();
            dgSessions.DataSource = sessionService.SelectAll();
        }

        private void DirectorLoad()
        {
            cmbDirectors.DisplayMember = "DirectorName";
            cmbDirectors.ValueMember = "DirectorID";
            cmbDirectors.DataSource = directorService.SelectAll();
            dgDirectors.DataSource = directorService.SelectAll();
        }

        private void GetAll()
        {
            dgTheaters.DataSource = theaterService.SelectAll();
        }

        // Genre Actions //

        private void AddGenre_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.Name = txtAddGenre.Text;
            genreService.Add(genre);

            ListViewItem lvi = new ListViewItem();
            lvi.Text = genre.GenreID.ToString();
            lvi.SubItems.Add(genre.Name);

            MessageBox.Show("" +genre.Name+ " movie type is added to list.");

            txtAddGenre.Text = "";
            dgGenre.DataSource = genreService.SelectAll();
        }

        private void AddSaloon_Click(object sender, EventArgs e)
        {
            Saloon saloon = new Saloon();
            saloon.Name = txtSaloonName.Text;
            saloon.Capacity = Convert.ToInt32(txtSaloonCap.Text);
            saloonService.Add(saloon);

            txtSaloonCap.Text = "";
            txtSaloonName.Text = "";

            dgSaloon.DataSource = saloonService.SelectAll();


            MessageBox.Show(saloon.Name + " Saloon is added with " + saloon.Capacity + " capacity.");

        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.Sessions = txtSessionAdd.Text;
            sessionService.Add(session);
            txtSessionAdd.Text = "";

            MessageBox.Show("Session : " +session.Sessions.ToString()+ " is added");

            dgSessions.DataSource = sessionService.SelectAll();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movy movie = new Movy();
            movie.Name = txtMovieName.Text;
            movie.Description = txtDescription.Text;
            movie.Duration = Convert.ToInt32(txtDuration.Text);

            movieService.Add(movie);

            dgTheaters.DataSource = movieService.SelectAll();
        }

        // Directors Section //

        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            Director dr = new Director();
            dr.DirectorName = txtDirectorName.Text;
            dr.DirectorSurname = txtDirectorSurname.Text;
            directorService.Add(dr);
            txtDirectorName.Text = "";
            txtDirectorSurname.Text = "";
            dgDirectors.DataSource = directorService.SelectAll();

            MessageBox.Show("Director : "+ dr.DirectorName + " " + dr.DirectorSurname + " is added");

        }

        private void btnSaloonDelete_Click(object sender, EventArgs e)
        {
            if (dgSaloon.SelectedRows.Count>0)
            {
                int id = Convert.ToInt32(dgSaloon.CurrentRow.Cells[0].Value);
                saloonService.Delete(id);
                MessageBox.Show("Selected Saloon deleted");
                SaloonLoad();
            }

            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        private void btnSessionDelete_Click(object sender, EventArgs e)
        {
            if (dgSessions.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgSessions.CurrentRow.Cells[0].Value);
                sessionService.Delete(id);
                MessageBox.Show("Selected Session deleted");
                SessionLoad();
            }

            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        private void btnDeleteDirector_Click(object sender, EventArgs e)
        {
            if (dgDirectors.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgDirectors.CurrentRow.Cells[0].Value);
                directorService.Delete(id);
                MessageBox.Show("Selected Director deleted");
                DirectorLoad();
            }

            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dgGenre.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgGenre.CurrentRow.Cells[0].Value);
                genreService.Delete(id);
                MessageBox.Show("Selected Genre Type deleted");
                GenreLoad();
            }

            else
            {
                MessageBox.Show("Please Select a row");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }
    }
}