# New ports collection makefile for:	texlive
# Date created:		2008-11-22
# Whom:			Romain Tartiere <romain@blogreen.org>
#
# $FreeBSD$
#

PORTNAME=	texlive-core
PORTVERSION=	20120628
CATEGORIES=	print
MASTER_SITES=	${MASTER_SITE_TEX_CTAN}
MASTER_SITE_SUBDIR=	systems/texlive/Source
DISTNAME=	texlive-${PORTVERSION}-source

MAINTAINER=	romain@FreeBSD.org
COMMENT=	TeXLive (binaries)

LIB_DEPENDS=	fontconfig:${PORTSDIR}/x11-fonts/fontconfig

CONFLICTS=	teTeX-base-[0-9]*

CFLAGS+=	-fPIC
CONFIGURE_ARGS=	--bindir=${PREFIX}/bin \
		--libdir=${PREFIX}/lib \
		--datadir=${PREFIX}/share \
		--enable-build-in-source-tree \
		--disable-native-texlive-build \
		--with-tex-banner="TeXLive 2012/FreeBSD"
GNU_CONFIGURE=	yes
MAKE_ARGS+=	GNUMAKE="${GMAKE}" ARCH="arch/unix"
USE_GMAKE=	yes
USE_PERL5=	yes
USE_XORG=	x11 xaw xmu xp xproto
USE_XZ=		yes

MAN1=		afm2pl.1 afm2tfm.1 aleph.1 allcm.1 allneeded.1 amstex.1 \
		bbox.1 bg5conv.1 bibtex.1 cef5conv.1 cefconv.1 cefsconv.1 \
		cfftot1.1 chktex.1 chkweb.1 context.1 ctangle.1 ctie.1 \
		ctxtools.1 cweave.1 cweb.1 detex.1 deweb.1 disdvi.1 dt2dv.1 \
		dv2dt.1 dvi2fax.1 dvi2tty.1 dvibook.1 dviconcat.1 dvicopy.1 \
		dvidvi.1 dvigif.1 dvihp.1 dvilj.1 dvipdfm.1 dvipdft.1 \
		dvipng.1 dvipos.1 dvips.1 dvired.1 dviselect.1 dvisvgm.1 \
		dvitodvi.1 dvitomp.1 dvitype.1 e2pall.1 ebb.1 eplain.1 \
		epsffit.1 extconv.1 extractbb.1 extractres.1 fixdlsrps.1 \
		fixfmps.1 fixpsditps.1 fixpspps.1 fixscribeps.1 fixtpps.1 \
		fixwfwps.1 fixwpps.1 fixwwps.1 fmtutil-sys.1 fmtutil.1 \
		fontinst.1 getafm.1 gftodvi.1 gftopk.1 gftype.1 gsftopk.1 \
		hbf2gf.1 includeres.1 kpseaccess.1 kpsepath.1 kpsereadlink.1 \
		kpsestat.1 kpsetool.1 kpsewhere.1 kpsewhich.1 lacheck.1 \
		lamed.1 latex.1 luatex.1 m-tx.1 mag.1 makeindex.1 mendex.1 \
		mf-nowin.1 mf.1 mft.1 mkindex.1 mkocp.1 mkofm.1 mktexlsr.1 \
		mktexmf.1 mktexpk.1 mktextfm.1 mmafm.1 mmpfb.1 mpost.1 \
		mptopdf.1 ofm2opl.1 opl2ofm.1 otangle.1 otfinfo.1 otftotfm.1 \
		otp2ocp.1 outocp.1 ovf2ovp.1 ovp2ovf.1 patgen.1 pdfclose.1 \
		pdfetex.1 pdflatex.1 pdfopen.1 pdftex.1 pdftosrc.1 pfb2pfa.1 \
		pk2bm.1 pktogf.1 pktype.1 pltotf.1 pmx2pdf.1 pmxab.1 \
		pooltype.1 prepmx.1 ps2eps.1 ps2frag.1 ps2pk.1 psbook.1 \
		pslatex.1 psmerge.1 psnup.1 psresize.1 psselect.1 pstopdf.1 \
		pstops.1 rubibtex.1 rumakeindex.1 scor2prt.1 sjisconv.1 \
		synctex.1 t1ascii.1 t1asm.1 t1binary.1 t1disasm.1 \
		t1dotlessj.1 t1lint.1 t1mac.1 t1rawafm.1 t1reencode.1 \
		t1testpage.1 t1unmac.1 tangle.1 tex.1 texconfig-sys.1 \
		texconfig.1 texdoctk.1 texexec.1 texlinks.1 texlua.1 \
		texluac.1 texmfstart.1 tftopl.1 thumbpdf.1 tie.1 \
		tpic2pdftex.1 ttf2afm.1 ttf2pk.1 ttf2tfm.1 ttfdump.1 \
		ttftotype42.1 updmap-sys.1 updmap.1 vftovp.1 vlna.1 vptovf.1 \
		weave.1 xdvi.1
MLINKS=		allcm.1 allec.1 dvilj.1 dvilj2p.1 dvilj.1 dvilj4.1 dvilj.1 \
		dvilj4l.1 dvilj.1 dvilj6.1 kpsetool.1 kpsexpand.1 fmtutil.1 \
		mktexfmt.1 dvicopy.1 odvicopy.1 dvips.1 odvips.1 dvitype.1 \
		odvitype.1 mktexlsr.1 texhash.1
MAN5=		fmtutil.cnf.5 synctex.5 updmap.cfg.5
INFO=		dvipng dvips kpathsea web2c

post-extract:
	@${FIND} ${WRKSRC} -name 'Makefile.in' | ${XARGS} ${SED} -EI '' \
	    -e 's,(\$$[{(]prefix[)}])/(texmf|\$$[{(]scriptsdir[)}]),\1/share/\2,'
	@${REINPLACE_CMD} 's/\$$(REL)\/texmf\//\$$(REL)\/share\/texmf\//g' ${WRKSRC}/texk/texlive/linked_scripts/Makefile.in
	@${REINPLACE_CMD} 's/\$$(REL)\/texmf-dist\//\$$(REL)\/share\/texmf-dist\//g' ${WRKSRC}/texk/texlive/linked_scripts/Makefile.in

post-install:
	@${LN} -sf pdftex ${PREFIX}/bin/amstex
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/bundledoc/arlatex ${PREFIX}/bin/arlatex
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/bibexport/bibexport.sh ${PREFIX}/bin/bibexport
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/bundledoc/bundledoc ${PREFIX}/bin/bundledoc
	@${LN} -sf pdftex ${PREFIX}/bin/cslatex
	@${LN} -sf pdftex ${PREFIX}/bin/csplain
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/de-macro/de-macro ${PREFIX}/bin/de-macro
	@${LN} -sf luatex ${PREFIX}/bin/dvilualatex
	@${LN} -sf luatex ${PREFIX}/bin/dviluatex
	@${LN} -sf pdftex ${PREFIX}/bin/eplain
	@${LN} -sf pdftex ${PREFIX}/bin/etex
	@${LN} -sf pdftex ${PREFIX}/bin/jadetex
	@${LN} -sf aleph ${PREFIX}/bin/lamed
	@${LN} -sf pdftex ${PREFIX}/bin/latex
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/latexdiff/latexdiff.pl ${PREFIX}/bin/latexdiff
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/latexdiff/latexdiff-vc.pl ${PREFIX}/bin/latexdiff-vc
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/latexdiff/latexrevise.pl ${PREFIX}/bin/latexrevise
	@${LN} -sf luatex ${PREFIX}/bin/lualatex
	@${LN} -sf mpost ${PREFIX}/bin/metafun
	@${LN} -sf pdftex ${PREFIX}/bin/mex
	@${LN} -sf mpost ${PREFIX}/bin/mfplain
	@${LN} -sf pdftex ${PREFIX}/bin/mllatex
	@${LN} -sf pdftex ${PREFIX}/bin/mltex
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdf180 ${PREFIX}/bin/pdf180
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdf270 ${PREFIX}/bin/pdf270
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdf90 ${PREFIX}/bin/pdf90
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfbook ${PREFIX}/bin/pdfbook
	@${LN} -sf pdftex ${PREFIX}/bin/pdfcslatex
	@${LN} -sf pdftex ${PREFIX}/bin/pdfcsplain
	@${LN} -sf pdftex ${PREFIX}/bin/pdfetex
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfflip ${PREFIX}/bin/pdfflip
	@${LN} -sf pdftex ${PREFIX}/bin/pdfjadetex
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfjam ${PREFIX}/bin/pdfjam
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfjam-pocketmod ${PREFIX}/bin/pdfjam-pocketmod
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfjam-slides3up ${PREFIX}/bin/pdfjam-slides3up
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfjam-slides6up ${PREFIX}/bin/pdfjam-slides6up
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfjoin ${PREFIX}/bin/pdfjoin
	@${LN} -sf pdftex ${PREFIX}/bin/pdflatex
	@${LN} -sf pdftex ${PREFIX}/bin/pdfmex
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfnup ${PREFIX}/bin/pdfnup
	@${LN} -sf ${PREFIX}/share/texmf-dist/scripts/pdfjam/pdfpun ${PREFIX}/bin/pdfpun
	@${LN} -sf pdftex ${PREFIX}/bin/pdfxmltex
	@${LN} -sf pdftex ${PREFIX}/bin/physe
	@${LN} -sf pdftex ${PREFIX}/bin/phyzzx
	@${LN} -sf pdftex ${PREFIX}/bin/texsis
	@${LN} -sf pdftex ${PREFIX}/bin/utf8mex
	@${LN} -sf xetex ${PREFIX}/bin/xelatex
	@${LN} -sf pdftex ${PREFIX}/bin/xmltex
.if defined(WITHOUT_TEXLIVE_MKTEXLSR)
	@${ECHO_CMD} "WITHOUT_TEXLIVE_MKTEXLSR is set.  Not running mktexlsr."
	@${ECHO_CMD} "You MUST run 'mktexlsr' to update TeXLive installed files database."
.else
	@${ECHO_CMD} "Updating ls-R databases..."
	@${PREFIX}/bin/mktexlsr
.endif

pretty-print-man1:
	${ECHO_CMD} ${MAN1:O} | fmt 60 60 | ${SED} -e 's|^|		|' -e 's|$$| \\|'

.include <bsd.port.mk>
