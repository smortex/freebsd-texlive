# New ports collection makefile for:	texlive-context-filter
# Date created:		09/29/2010 04:35:38
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	context-filter
PORTVERSION=	20110721
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Run external programs on the contents of a start-stop environment.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
