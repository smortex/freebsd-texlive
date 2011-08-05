# New ports collection makefile for:	texlive-context-simplefonts
# Date created:		13/03/2010 04:21:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-simplefonts
PORTVERSION=	20110805
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Simplified font usage for ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
