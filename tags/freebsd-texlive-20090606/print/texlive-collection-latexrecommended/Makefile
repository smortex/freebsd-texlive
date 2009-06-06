# New ports collection makefile for:	texlive-collection-latexrecommended
# Date created:		26/01/2009 16:10:23
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-latexrecommended
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	LaTeX recommended packages

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/anysize/anysize.sty:${PORTSDIR}/print/texlive-anysize \
		${LOCALBASE}/share/texmf-dist/tex/latex/beamer/beamer.cls:${PORTSDIR}/print/texlive-beamer \
		${LOCALBASE}/share/texmf-dist/tex/latex/booktabs/booktabs.sty:${PORTSDIR}/print/texlive-booktabs \
		${LOCALBASE}/share/texmf-dist/tex/latex/caption/caption.sty:${PORTSDIR}/print/texlive-caption \
		${LOCALBASE}/share/texmf-dist/tex/latex/cite/cite.sty:${PORTSDIR}/print/texlive-cite \
		${LOCALBASE}/share/texmf-dist/tex/latex/citeref/citeref.sty:${PORTSDIR}/print/texlive-citeref \
		${LOCALBASE}/share/texmf-dist/tex/latex/cmap/cmap.sty:${PORTSDIR}/print/texlive-cmap \
		${LOCALBASE}/share/texmf-dist/tex/latex/crop/crop.sty:${PORTSDIR}/print/texlive-crop \
		${LOCALBASE}/share/texmf-dist/tex/latex/ctable/ctable.sty:${PORTSDIR}/print/texlive-ctable \
		${LOCALBASE}/share/texmf-dist/fonts/source/jknappen/ec/ecbi.mf:${PORTSDIR}/print/texlive-ec \
		${LOCALBASE}/share/texmf-dist/tex/latex/eso-pic/eso-pic.sty:${PORTSDIR}/print/texlive-eso-pic \
		${LOCALBASE}/share/texmf-dist/tex/latex/euler/euler.sty:${PORTSDIR}/print/texlive-euler \
		${LOCALBASE}/share/texmf-dist/tex/latex/extsizes/extsizes.sty:${PORTSDIR}/print/texlive-extsizes \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancybox/fancybox.sty:${PORTSDIR}/print/texlive-fancybox \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancyref/fancyref.sty:${PORTSDIR}/print/texlive-fancyref \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancyvrb/fancyvrb.sty:${PORTSDIR}/print/texlive-fancyvrb \
		${LOCALBASE}/share/texmf-dist/tex/latex/float/float.sty:${PORTSDIR}/print/texlive-float \
		${LOCALBASE}/share/texmf-dist/tex/latex/fp/fp.sty:${PORTSDIR}/print/texlive-fp \
		${LOCALBASE}/share/texmf-dist/tex/latex/index/index.sty:${PORTSDIR}/print/texlive-index \
		${LOCALBASE}/share/texmf-dist/tex/latex/jknapltx/greekctr.sty:${PORTSDIR}/print/texlive-jknapltx \
		${LOCALBASE}/share/texmf-dist/doc/latex/koma-script/INSTALL.txt:${PORTSDIR}/print/texlive-koma-script \
		${LOCALBASE}/share/texmf-dist/tex/latex/listings/listings.sty:${PORTSDIR}/print/texlive-listings \
		${LOCALBASE}/share/texmf-dist/tex/latex/mdwtools/at.sty:${PORTSDIR}/print/texlive-mdwtools \
		${LOCALBASE}/share/texmf-dist/tex/latex/memoir/memoir.cls:${PORTSDIR}/print/texlive-memoir \
		${LOCALBASE}/share/texmf-dist/tex/latex/microtype/microtype.sty:${PORTSDIR}/print/texlive-microtype \
		${LOCALBASE}/share/texmf-dist/tex/latex/ms/count1to.sty:${PORTSDIR}/print/texlive-ms \
		${LOCALBASE}/share/texmf-dist/tex/latex/ntgclass/a4.sty:${PORTSDIR}/print/texlive-ntgclass \
		${LOCALBASE}/share/texmf-dist/tex/latex/pdfpages/pdfpages.sty:${PORTSDIR}/print/texlive-pdfpages \
		${LOCALBASE}/share/texmf-dist/tex/latex/powerdot/powerdot.cls:${PORTSDIR}/print/texlive-powerdot \
		${LOCALBASE}/share/texmf-dist/tex/latex/psfrag/psfrag.sty:${PORTSDIR}/print/texlive-psfrag \
		${LOCALBASE}/share/texmf-dist/tex/latex/rcs/rcs.sty:${PORTSDIR}/print/texlive-rcs \
		${LOCALBASE}/share/texmf-dist/tex/latex/rotating/rotating.sty:${PORTSDIR}/print/texlive-rotating \
		${LOCALBASE}/share/texmf-dist/tex/latex/seminar/seminar.cls:${PORTSDIR}/print/texlive-seminar \
		${LOCALBASE}/share/texmf-dist/tex/latex/setspace/setspace.sty:${PORTSDIR}/print/texlive-setspace \
		${LOCALBASE}/share/texmf-dist/tex/latex/subfig/subfig.sty:${PORTSDIR}/print/texlive-subfig \
		${LOCALBASE}/share/texmf-dist/tex/generic/thumbpdf/thumbpdf.sty:${PORTSDIR}/print/texlive-thumbpdf \
		${LOCALBASE}/share/texmf-dist/tex/latex/xcolor/xcolor.sty:${PORTSDIR}/print/texlive-xcolor \
		${LOCALBASE}/share/texmf-dist/tex/generic/xkeyval/xkeyval.tex:${PORTSDIR}/print/texlive-xkeyval \
		${LOCALBASE}/share/texmf-dist/tex/latex/ae/ae.sty:${PORTSDIR}/print/texlive-ae \
		${LOCALBASE}/share/texmf-dist/tex/latex/amscls/amsart.cls:${PORTSDIR}/print/texlive-amscls \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsmath/amsmath.sty:${PORTSDIR}/print/texlive-amsmath \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsrefs/amsrefs.sty:${PORTSDIR}/print/texlive-amsrefs \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel/babel.sty:${PORTSDIR}/print/texlive-babel \
		${LOCALBASE}/share/texmf-dist/tex/latex/babelbib/babelbib.sty:${PORTSDIR}/print/texlive-babelbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/carlisle/blkarray.sty:${PORTSDIR}/print/texlive-carlisle \
		${LOCALBASE}/share/texmf-dist/tex/latex/colortbl/colortbl.sty:${PORTSDIR}/print/texlive-colortbl \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancyhdr/fancyhdr.sty:${PORTSDIR}/print/texlive-fancyhdr \
		${LOCALBASE}/share/texmf-dist/tex/latex/geometry/geometry.sty:${PORTSDIR}/print/texlive-geometry \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics/graphics.sty:${PORTSDIR}/print/texlive-graphics \
		${LOCALBASE}/share/texmf-dist/tex/latex/hyperref/hyperref.sty:${PORTSDIR}/print/texlive-hyperref \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/bluesky/latex-fonts/lasy10.afm:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/latex.ini:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/tex/latex/ltxmisc/2in1.sty:${PORTSDIR}/print/texlive-ltxmisc \
		${LOCALBASE}/share/texmf-dist/tex/latex/mfnfss/oldgerm.sty:${PORTSDIR}/print/texlive-mfnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/natbib/natbib.sty:${PORTSDIR}/print/texlive-natbib \
		${LOCALBASE}/share/texmf-dist/scripts/oberdiek/luacolor.lua:${PORTSDIR}/print/texlive-oberdiek \
		${LOCALBASE}/share/texmf-dist/tex/latex/pdftex-def/pdftex.def:${PORTSDIR}/print/texlive-pdftex-def \
		${LOCALBASE}/share/texmf-dist/tex/latex/pslatex/pslatex.sty:${PORTSDIR}/print/texlive-pslatex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/psnfss/charter.map:${PORTSDIR}/print/texlive-psnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/pspicture/pspicture.sty:${PORTSDIR}/print/texlive-pspicture \
		${LOCALBASE}/share/texmf-dist/tex/latex/tools/.tex:${PORTSDIR}/print/texlive-tools \
		${LOCALBASE}/share/texmf/fmtutil/format.latex.cnf:${PORTSDIR}/print/texlive-bin-latex \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/ams/amsj.bib:${PORTSDIR}/print/texlive-ams \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/dvips/cm/config.cm:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cmex/ttcmex.map:${PORTSDIR}/print/texlive-cmex \
		${LOCALBASE}/share/texmf-dist/dvips/base/ehandler.ps:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/tex/plain/etex/etex.src:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/dvipdfm/config/config:${PORTSDIR}/print/texlive-bin-dvipdfm \
		${LOCALBASE}/share/texmf/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-bin-dvipdfmx \
		${LOCALBASE}/share/texmf/dvips/base/color.pro:${PORTSDIR}/print/texlive-bin-dvipsk \
		${LOCALBASE}/share/texmf/scripts/texlive/getnonfreefonts.pl:${PORTSDIR}/print/texlive-bin-getnonfreefonts \
		${LOCALBASE}/share/texmf/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-bin-gsftopk \
		${LOCALBASE}/share/texmf/fmtutil/format.metafont.cnf:${PORTSDIR}/print/texlive-bin-metafont \
		${LOCALBASE}/share/texmf/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-bin-tetex \
		${LOCALBASE}/share/texmf/fmtutil/fmtutil-hdr.cnf:${PORTSDIR}/print/texlive-bin-texlive \
		${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/share/texmf/texconfig/README:${PORTSDIR}/print/texlive-bin-texconfig \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-bin-xdvi \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf/fmtutil/format.luatex.cnf:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
