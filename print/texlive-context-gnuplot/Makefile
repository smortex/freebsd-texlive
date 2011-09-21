# New ports collection makefile for:	texlive-context-gnuplot
# Date created:		13/03/2010 04:21:38
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-gnuplot
PORTVERSION=	20110921
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Inclusion of Gnuplot graphs in ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
