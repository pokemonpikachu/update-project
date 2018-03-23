 public ActionResult upd(string i)
        {
            Session["id"] = i;
            ViewBag.T = db.sp_tbl2_subsc_team9(i).ToList();
            return View("upd");
        }
        [HttpPost]
        public ActionResult upd(tbl2_subsc_team9 tl)
        {
            string i=Session["id"].ToString();
            // if (ModelState.IsValid)
            // {
            ViewBag.T = db.sp_tbl2_subsc_team9(i).ToList();
                 
                db.spupdatedetails3(i, tl.name, tl.dob, tl.contact_num, tl.email, tl.sim_no, tl.addr1, tl.addr2, tl.city, tl.pincode,tl.stat);
               
            Response.Write("<script>alert('Updated Successfully')</script>");
            //}
           // else
             //   Response.Write("<script>alert('Sorry,Could not update')</script>");
            return RedirectToAction("view");
        }
