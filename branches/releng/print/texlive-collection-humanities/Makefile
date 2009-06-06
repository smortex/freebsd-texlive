# New ports collection makefile for:	texlive-collection-humanities
# Date created:		26/01/2009 16:05:33
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-humanities
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Humanities packages

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/alnumsec/alnumsec.sty:${PORTSDIR}/print/texlive-alnumsec \
		${LOCALBASE}/share/texmf-dist/tex/latex/arydshln/arydshln.sty:${PORTSDIR}/print/texlive-arydshln \
		${LOCALBASE}/share/texmf-dist/tex/latex/bibleref/bibleref.sty:${PORTSDIR}/print/texlive-bibleref \
		${LOCALBASE}/share/texmf-dist/tex/latex/covington/covington.sty:${PORTSDIR}/print/texlive-covington \
		${LOCALBASE}/share/texmf-dist/tex/latex/dramatist/dramatist.sty:${PORTSDIR}/print/texlive-dramatist \
		${LOCALBASE}/share/texmf-dist/tex/latex/ecltree/ecltree.sty:${PORTSDIR}/print/texlive-ecltree \
		${LOCALBASE}/share/texmf-dist/tex/latex/ednotes/ednotes.sty:${PORTSDIR}/print/texlive-ednotes \
		${LOCALBASE}/share/texmf-dist/tex/latex/gb4e/gb4e.sty:${PORTSDIR}/print/texlive-gb4e \
		${LOCALBASE}/share/texmf-dist/tex/latex/gmverse/gmverse.sty:${PORTSDIR}/print/texlive-gmverse \
		${LOCALBASE}/share/texmf-dist/tex/latex/jura/jura.cls:${PORTSDIR}/print/texlive-jura \
		${LOCALBASE}/share/texmf-dist/tex/latex/juraabbrev/juraabbrev.sty:${PORTSDIR}/print/texlive-juraabbrev \
		${LOCALBASE}/share/texmf-dist/tex/latex/juramisc/jbgoe.clo:${PORTSDIR}/print/texlive-juramisc \
		${LOCALBASE}/share/texmf-dist/tex/latex/jurarsp/jurarsp.sty:${PORTSDIR}/print/texlive-jurarsp \
		${LOCALBASE}/share/texmf-dist/tex/latex/ledmac/ledmac.sty:${PORTSDIR}/print/texlive-ledmac \
		${LOCALBASE}/share/texmf-dist/tex/latex/lexikon/lexikon.sty:${PORTSDIR}/print/texlive-lexikon \
		${LOCALBASE}/share/texmf-dist/tex/latex/lineno/lineno.sty:${PORTSDIR}/print/texlive-lineno \
		${LOCALBASE}/share/texmf-dist/tex/latex/linguex/linguex.sty:${PORTSDIR}/print/texlive-linguex \
		${LOCALBASE}/share/texmf-dist/tex/latex/liturg/liturg.sty:${PORTSDIR}/print/texlive-liturg \
		${LOCALBASE}/share/texmf-dist/tex/latex/parallel/parallel.sty:${PORTSDIR}/print/texlive-parallel \
		${LOCALBASE}/share/texmf-dist/tex/latex/parrun/parrun.sty:${PORTSDIR}/print/texlive-parrun \
		${LOCALBASE}/share/texmf-dist/tex/latex/plari/plari.cls:${PORTSDIR}/print/texlive-plari \
		${LOCALBASE}/share/texmf-dist/tex/latex/play/play.cls:${PORTSDIR}/print/texlive-play \
		${LOCALBASE}/share/texmf-dist/tex/latex/poemscol/poemscol.sty:${PORTSDIR}/print/texlive-poemscol \
		${LOCALBASE}/share/texmf-dist/tex/latex/qobitree/qobitree.tex:${PORTSDIR}/print/texlive-qobitree \
		${LOCALBASE}/share/texmf-dist/tex/latex/qtree/qtree.sty:${PORTSDIR}/print/texlive-qtree \
		${LOCALBASE}/share/texmf-dist/tex/latex/rtklage/rtklage.cls:${PORTSDIR}/print/texlive-rtklage \
		${LOCALBASE}/share/texmf-dist/tex/latex/screenplay/screenplay.cls:${PORTSDIR}/print/texlive-screenplay \
		${LOCALBASE}/share/texmf-dist/tex/latex/sides/sides.cls:${PORTSDIR}/print/texlive-sides \
		${LOCALBASE}/share/texmf-dist/tex/latex/stage/stage.cls:${PORTSDIR}/print/texlive-stage \
		${LOCALBASE}/share/texmf-dist/tex/latex/tree-dvips/tree-dvips.sty:${PORTSDIR}/print/texlive-tree-dvips \
		${LOCALBASE}/share/texmf-dist/tex/latex/verse/verse.sty:${PORTSDIR}/print/texlive-verse \
		${LOCALBASE}/share/texmf-dist/tex/latex/xyling/xyling.sty:${PORTSDIR}/print/texlive-xyling

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
