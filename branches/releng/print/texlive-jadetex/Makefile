# New ports collection makefile for:	texlive-jadetex
# Date created:		26/01/2009 16:05:21
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	jadetex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Macros supporting Jade DSSSL output.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.jadetex.cnf:${PORTSDIR}/print/texlive-bin-jadetex

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
