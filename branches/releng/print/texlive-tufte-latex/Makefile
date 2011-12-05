# New ports collection makefile for:	texlive-tufte-latex
# Date created:		13/03/2010 04:52:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	tufte-latex
PORTVERSION=	20111205
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Document classes inspired by the work of Edward Tufte.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/xifthen/xifthen.sty:${PORTSDIR}/print/texlive-xifthen \
		${LOCALBASE}/share/texmf-dist/tex/latex/ifmtarg/ifmtarg.sty:${PORTSDIR}/print/texlive-ifmtarg \
		${LOCALBASE}/share/texmf-dist/tex/latex/changepage/changepage.sty:${PORTSDIR}/print/texlive-changepage \
		${LOCALBASE}/share/texmf-dist/tex/latex/paralist/paralist.sty:${PORTSDIR}/print/texlive-paralist \
		${LOCALBASE}/share/texmf-dist/tex/latex/sauerj/collect.sty:${PORTSDIR}/print/texlive-sauerj \
		${LOCALBASE}/share/texmf-dist/tex/latex/placeins/placeins.sty:${PORTSDIR}/print/texlive-placeins


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
